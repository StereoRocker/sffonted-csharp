using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _88fonted
{
    public partial class frmMain : Form
    {
        
        #region Runtime variables

        byte[,] font;
        enum DrawMode
        {
            SELECT,
            PENCIL,
            ERASER,
            LINE,
            RECTANGLE
        }
        DrawMode mode;
        int selected = 0;
        bool saved = true;

        #endregion

        #region Application constants

        private Pen _OUTLINE = Pens.LightGray;
        private Pen _SELECTED = Pens.Red;

        private const uint _VERSION_MAJOR = 1;
        private const uint _VERSION_MINOR = 0;
        private readonly byte[] _MAGIC = { 0x53, 0x46, 0x46 };
        private const int _RESERVED_COUNT = 4;

        #endregion

        #region Font file I/O code

        void NewFont()
        {
            font = new byte[96, 8];
        }

        void LoadFont(string path)
        {
            FileInfo fi = new FileInfo(path);
            FileStream fs = File.OpenRead(path);

            // Validate header magic
            byte[] _MAGIC = { 0x53, 0x46, 0x46 };
            byte[] header = new byte[8];
            fs.Read(header, 0, 8);

            for (int i = 0; i < _MAGIC.Length; i++)
            {
                if (header[i] != _MAGIC[i])
                {
                    fs.Close();
                    throw new InvalidFileFormatException("Incorrect magic in header");
                }
            }

            // Validate the version
            if ((header[3] >> 4) != _VERSION_MAJOR)
                throw new InvalidFileFormatException(string.Format("Incorrect format major version.\nExpected major version 1, got version {0}.", (header[3] >> 4)));

            if ((header[3] & 0x0F) > _VERSION_MINOR)
                MessageBox.Show(string.Format("This font was created in a newer format than this tool supports. This tool supports minor versions up to {0}, but this file was created with minor version {1}.\n\n" +
                    "This doesn't necessarily pose an issue, as backwards compatibility in minor versions should be considered. However, it is possible some information will not be read by this version of the tool.\n\n" +
                    "Please visit https://www.stereorocker.co.uk/ to see if there is an update for this tool.", _VERSION_MINOR, (header[3] & 0x0F)), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // For now, the last 4 bytes in the header are reserved. It may be used to describe the shape and number of characters, in a future revision
            // For this reason, to remain forwards compatible for fonts stored in the format we expect, do no checks on the reserved bytes.

            // Validate the file length
            if (fi.Length < (96 * 8) + 8)
            {
                fs.Close();
                throw new InvalidFileFormatException("File length too short");
            }
            else if (fi.Length > (96 * 8) + 8)
            {
                MessageBox.Show(string.Format("The loaded file is longer than expected. While this doesn't necessarily pose an issue, editing and saving this file may result in loss information, or the font may not read properly in this version of the tool.\n\nHeader reserved bytes: {0} {1} {2}", header[5].ToString("X2"), header[6].ToString("X2"), header[7].ToString("X2")), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Read the font values
            for (int i = 0; i < 96; i++)
                for (int j = 0; j < 8; j++)
                    font[i, j] = (byte)fs.ReadByte();
            fs.Close();
        }

        void SaveFont(string path)
        {
            FileStream fs = File.OpenWrite(path);

            // Write header magic
            fs.Write(_MAGIC, 0, _MAGIC.Length);

            // Write header version
            byte version = (byte)((_VERSION_MAJOR << 4) + _VERSION_MINOR);
            fs.WriteByte(version);

            // Write reserved bytes
            fs.Write(new byte[_RESERVED_COUNT], 0, _RESERVED_COUNT);

            // Write the data
            for (int i = 0; i < 96; i++)
            {
                for (int j = 0; j < 8; j++)
                    fs.WriteByte(font[i, j]);
            }

            // Close file
            fs.Close();
        }

        void SaveFontAsC(string path)
        {
            FileStream fs = File.OpenWrite(path);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(@"#ifndef FONT_H");
            sw.WriteLine(@"#define FONT_H");
            sw.WriteLine();

            sw.WriteLine(@"#include <stdint.h>");
            sw.WriteLine();

            sw.WriteLine(@"uint8_t* font = {");

            for (int i = 0; i < 96; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (j != 0)
                        sw.Write(", ");
                    sw.Write(String.Format("0x{0}", font[i, j].ToString("X2")));
                }
                sw.WriteLine();
            }

            sw.WriteLine(@"};");

            sw.WriteLine();
            sw.WriteLine(@"#endif //FONT_H");

            sw.Close();
        }

        #endregion

        #region Character drawing code

        private void DrawCharacter(ref Graphics g, int charindex, int dx, int dy, int scale, bool outline)
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    if (((font[charindex, y] << x) & 0x80) == 0x80)
                        g.FillRectangle(Brushes.White, (x * scale) + dx, (y * scale) + dy, scale, scale);
                    else
                        g.FillRectangle(Brushes.Black, (x * scale) + dx, (y * scale) + dy, scale, scale);

                    if (outline)
                        g.DrawRectangle(_OUTLINE, (x * scale) + dx, (y * scale) + dy, scale-1, scale-1);

                    
                }
            }
        }
        #endregion

        #region Character editor code
        private void panFontCharacter_Paint(object sender, PaintEventArgs e)
        {
            // Paint the currently selected character

            // Determine scale
            int MaxSize = Math.Min(panFontCharacter.Size.Width, panFontCharacter.Size.Height);
            int scale = MaxSize / 8;

            // Paint the pixels to a buffer
            Bitmap b = new Bitmap(MaxSize, MaxSize);
            Graphics g = Graphics.FromImage(b);

            DrawCharacter(ref g, selected, 0, 0, scale, (scale > 4));

            // Draw the buffer to the screen
            e.Graphics.Clear(Color.Black);
            e.Graphics.DrawImageUnscaled(b, 0, 0);
            //e.Graphics.DrawRectangle(_OUTLINE, 0, 0, MaxSize, MaxSize);
            g.Dispose();
            b.Dispose();
        }

        private void panFontCharacter_Resize(object sender, EventArgs e)
        {
            panFontCharacter.Invalidate();
        }

        private int startX = -1;
        private int startY = -1;
        private bool drawing = false;

        private void panFontCharacter_MouseDown(object sender, MouseEventArgs e)
        {
            // Validate we had a left click
            if (e.Button != MouseButtons.Left)
                return;

            // Determine scale
            int MaxSize = Math.Min(panFontCharacter.Size.Width, panFontCharacter.Size.Height);
            int scale = MaxSize / 8;

            // Determine clicked cell
            int x = e.X / scale;
            int y = e.Y / scale;

            // Validate clicked cell
            if ((x > 7) || (y > 7))
                return;

            // Switch based on mode
            bool redraw = false;
            switch (mode)
            {
                case DrawMode.SELECT:
                    // The select tool should do nothing
                    return;

                case DrawMode.PENCIL:
                    // The pencil tool should start drawing, and continue to draw while held
                    redraw = true;
                    saved = false;
                    startX = x;
                    startY = y;
                    drawing = true;

                    font[selected, y] |= (byte)(0x80 >> x);
                    break;

                case DrawMode.ERASER:
                    // The pencil tool should start drawing, and continue to draw while held
                    redraw = true;
                    saved = false;
                    startX = x;
                    startY = y;
                    drawing = true;

                    // Un-set the specified bit
                    font[selected, y] &= (byte)~(0x80 >> x);

                    
                    break;
            }

            // Redraw panels, if necessary
            if (redraw)
            {
                panFontSet.Invalidate();
                panFontCharacter.Invalidate();
            }
        }

        private void panFontCharacter_MouseMove(object sender, MouseEventArgs e)
        {
            // If we aren't mid-draw, do nothing
            if (!drawing)
                return;

            // Determine scale
            int MaxSize = Math.Min(panFontCharacter.Size.Width, panFontCharacter.Size.Height);
            int scale = MaxSize / 8;

            // Determine clicked cell
            int x = e.X / scale;
            int y = e.Y / scale;

            // Validate clicked cell
            if ((x > 7) || (y > 7))
                return;

            // Switch based on mode. Not including SELECT, as this mode doesn't ever start drawing
            bool redraw = false;
            switch (mode)
            {
                case DrawMode.PENCIL:
                    if ((x != startX) || (y != startY))
                    {
                        redraw = true;
                        font[selected, y] |= (byte)(0x80 >> x);
                        startX = x;
                        startY = y;
                    }
                    break;

                case DrawMode.ERASER:
                    if ((x != startX) || (y != startY))
                    {
                        redraw = true;
                        font[selected, y] &= (byte)~(0x80 >> x);
                        startX = x;
                        startY = y;
                    }
                    break;
            }

            if (redraw)
            {
                panFontSet.Invalidate();
                panFontCharacter.Invalidate();
            }
        }

        private void panFontCharacter_MouseUp(object sender, MouseEventArgs e)
        {
            // If we aren't mid-draw, do nothing. Though this should never happen.
            if (!drawing)
                return;

            // Determine scale
            int MaxSize = Math.Min(panFontCharacter.Size.Width, panFontCharacter.Size.Height);
            int scale = MaxSize / 8;

            // Determine clicked cell
            int x = e.X / scale;
            int y = e.Y / scale;

            // Validate clicked cell - though don't return, individual modes should decide what to do here
            bool valid = (x > 7) || (y > 7);
            
            // Switch based on mode. Not including SELECT, as this mode doesn't ever start drawing
            switch (mode)
            {
                case DrawMode.PENCIL:
                    // We have already flipped all the bits we need to
                    drawing = false;
                    break;

                case DrawMode.ERASER:
                    // We have already flipped all the bits we need to
                    drawing = false;
                    break;
            }
        }

        #endregion

        #region Character selector code

        private void panFontSet_Paint(object sender, PaintEventArgs e)
        {
            // Paint all current font characters

            // What's the biggest we can draw all characters?
            // Or is it better to scale 8x12 to the current size?
            // Is it best to draw 8x12 at true size to a buffer/image then draw that to the panel? - not this.

            // Determine scale
            int MaxWidth = (panFontSet.Size.Width) / 8;
            int MaxHeight = (panFontSet.Size.Height) / 12;
            int MaxSize = Math.Min(MaxWidth, MaxHeight);
            MaxSize -= (MaxSize % 8);

            int characterScale = MaxSize / 8;
            int pixelScale = characterScale / 8;

            // Paint the pixels to a buffer
            Bitmap b = new Bitmap(MaxSize * 8, MaxSize * 12);
            Graphics g = Graphics.FromImage(b);
            for (int y = 0; y < 12; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    int current = (y * 8) + x;
                    DrawCharacter(ref g, current, x * MaxSize, y * MaxSize, characterScale, false);

                    if (current == selected)
                        g.DrawRectangle(_SELECTED, x * MaxSize, y * MaxSize, MaxSize - 1, MaxSize - 1);
                    else
                        g.DrawRectangle(_OUTLINE, x * MaxSize, y * MaxSize, MaxSize - 1, MaxSize - 1);
                }
            }

            e.Graphics.Clear(Color.Black);
            e.Graphics.DrawImageUnscaled(b, 0, 0);

            g.Dispose();
            b.Dispose();
        }

        private void panFontSet_Resize(object sender, EventArgs e)
        {
            panFontSet.Invalidate();
        }

        private void panFontSet_MouseClick(object sender, MouseEventArgs e)
        {
            // Determine scale
            int MaxWidth = (panFontSet.Size.Width) / 8;
            int MaxHeight = (panFontSet.Size.Height) / 12;
            int MaxSize = Math.Min(MaxWidth, MaxHeight);
            MaxSize -= (MaxSize % 8);

            // Determine clicked cell
            int x = e.X / MaxSize;
            int y = e.Y / MaxSize;

            // Validate clicked cell
            if ((x > 7) || (y > 11))
                return;

            // Update selected, redraw panels
            selected = (y * 8) + x;
            panFontSet.Invalidate();
            panFontCharacter.Invalidate();
        }

        #endregion

        #region GUI event handling

        // This is a separate function to the Save menu button click handler, so it can be called by SaveVeto() as well.
        // Returns true if the font was saved, otherwise false.
        bool SaveDialogRoutine()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save font";
            sfd.Filter = "Small Font Format (*.sff) | *.sff";
            sfd.DefaultExt = "sff";
            DialogResult result = sfd.ShowDialog();

            // Return if not accepted
            if (result != DialogResult.OK)
                return false;

            // Write the file
            SaveFont(sfd.FileName);

            // Mark font as saved
            saved = true;

            // Return successful save
            return true;
        }

        // Returns false, if no action is required, true if the action should be cancelled
        bool VetoSave(string message)
        {
            DialogResult result = MessageBox.Show(message, "Small Font Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    return !SaveDialogRoutine();

                case DialogResult.No:
                    return false;

                case DialogResult.Cancel:
                    return true;

                default:
                    // We should never reach this code, but if we do, veto
                    return true;
            }
        }

        // Updates the toolbar based on the current drawing mode
        private void UpdateToolbar()
        {
            cmdSelect.Checked = (mode == DrawMode.SELECT);
            cmdPencil.Checked = (mode == DrawMode.PENCIL);
            cmdEraser.Checked = (mode == DrawMode.ERASER);
            cmdLine.Checked = (mode == DrawMode.LINE);
            cmdRectangle.Checked = (mode == DrawMode.RECTANGLE);
        }

        #region Toolbar button handlers

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            mode = DrawMode.SELECT;
            UpdateToolbar();
        }

        private void cmdPencil_Click(object sender, EventArgs e)
        {
            mode = DrawMode.PENCIL;
            UpdateToolbar();
        }

        private void cmdEraser_Click(object sender, EventArgs e)
        {
            mode = DrawMode.ERASER;
            UpdateToolbar();
        }

        private void cmdLine_Click(object sender, EventArgs e)
        {
            mode = DrawMode.LINE;
            UpdateToolbar();
        }

        private void cmdRectangle_Click(object sender, EventArgs e)
        {
            mode = DrawMode.RECTANGLE;
            UpdateToolbar();
        }

        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
                if (VetoSave("Save changes before closing?"))
                    e.Cancel = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If unsaved, check if veto is required
            if (!saved)
                if (VetoSave("Save changes before creating new font?"))
                    return;

            // Re-initialise font in memory
            NewFont();

            // Re-draw panels
            panFontSet.Invalidate();
            panFontCharacter.Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If unsaved, check if veto is required
            if (!saved)
                if (VetoSave("Save changes before opening new font?"))
                    return;

            // Open file dialog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Load font";
            ofd.Filter = "Small Font Format (*.sff) | *.sff";
            ofd.DefaultExt = "sff";
            ofd.Multiselect = false;
            DialogResult result = ofd.ShowDialog();

            // Return if not accepted
            if (result != DialogResult.OK)
                return;


            // Call loading code, handle exceptions
            try { LoadFont(ofd.FileName); }
            catch (InvalidFileFormatException ex)
            {
                MessageBox.Show("Error loading font file:\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selected = 0;

            // Draw panels
            panFontSet.Invalidate();
            panFontCharacter.Invalidate();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Call the save dialog routine
            SaveDialogRoutine();
        }

        private void exportToCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export font as C header";
            sfd.Filter = "C header (*.h) | *.h";
            sfd.DefaultExt = "h";
            DialogResult result = sfd.ShowDialog();

            // Return if not accepted
            if (result != DialogResult.OK)
                return;

            // Write the file
            SaveFontAsC(sfd.FileName);

            // We don't mark the font as saved, as we won't implement restoring from a C header

        }

        #endregion

        public class InvalidFileFormatException : System.FormatException
        {
            public InvalidFileFormatException(string exText) : base(exText) { }
        }

        public frmMain()
        {
            InitializeComponent();

            NewFont();
            mode = DrawMode.SELECT;

        }

    }
}
