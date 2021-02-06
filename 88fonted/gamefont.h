#ifndef FONT_H
#define FONT_H

#include <stdint.h>

uint8_t* font = {
0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
0x08, 0x08, 0x08, 0x08, 0x00, 0x08, 0x00, 0x00
0x28, 0x28, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
0x00, 0x28, 0x7C, 0x28, 0x7C, 0x28, 0x00, 0x00
0x08, 0x1E, 0x28, 0x1C, 0x0A, 0x3C, 0x08, 0x00
0x60, 0x94, 0x68, 0x16, 0x29, 0x06, 0x00, 0x00
0x1C, 0x20, 0x20, 0x19, 0x26, 0x19, 0x00, 0x00
0x08, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
0x08, 0x10, 0x20, 0x20, 0x10, 0x08, 0x00, 0x00
0x10, 0x08, 0x04, 0x04, 0x08, 0x10, 0x00, 0x00
0x2A, 0x1C, 0x3E, 0x1C, 0x2A, 0x00, 0x00, 0x00
0x00, 0x08, 0x08, 0x3E, 0x08, 0x08, 0x00, 0x00
0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x10, 0x00
0x00, 0x00, 0x00, 0x3C, 0x00, 0x00, 0x00, 0x00
0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00
0x02, 0x04, 0x08, 0x10, 0x20, 0x40, 0x00, 0x00
0x18, 0x24, 0x42, 0x42, 0x24, 0x18, 0x00, 0x00
0x08, 0x18, 0x08, 0x08, 0x08, 0x1C, 0x00, 0x00
0x3C, 0x42, 0x04, 0x18, 0x20, 0x7E, 0x00, 0x00
0x3C, 0x42, 0x04, 0x18, 0x42, 0x3C, 0x00, 0x00
0x08, 0x18, 0x28, 0x48, 0x7C, 0x08, 0x00, 0x00
0x7E, 0x40, 0x7C, 0x02, 0x42, 0x3C, 0x00, 0x00
0x3C, 0x40, 0x7C, 0x42, 0x42, 0x3C, 0x00, 0x00
0x7E, 0x04, 0x08, 0x10, 0x20, 0x40, 0x00, 0x00
0x3C, 0x42, 0x3C, 0x42, 0x42, 0x3C, 0x00, 0x00
0x3C, 0x42, 0x42, 0x3E, 0x02, 0x3C, 0x00, 0x00
0x00, 0x00, 0x08, 0x00, 0x00, 0x08, 0x00, 0x00
0x00, 0x00, 0x08, 0x00, 0x00, 0x08, 0x10, 0x00
0x00, 0x06, 0x18, 0x60, 0x18, 0x06, 0x00, 0x00
0x00, 0x00, 0x7E, 0x00, 0x7E, 0x00, 0x00, 0x00
0x00, 0x60, 0x18, 0x06, 0x18, 0x60, 0x00, 0x00
0x38, 0x44, 0x04, 0x18, 0x00, 0x10, 0x00, 0x00
0x00, 0x3C, 0x44, 0x9C, 0x94, 0x5C, 0x20, 0x1C
0x18, 0x18, 0x24, 0x3C, 0x42, 0x42, 0x00, 0x00
0x78, 0x44, 0x78, 0x44, 0x44, 0x78, 0x00, 0x00
0x38, 0x44, 0x80, 0x80, 0x44, 0x38, 0x00, 0x00
0x78, 0x44, 0x44, 0x44, 0x44, 0x78, 0x00, 0x00
0x7C, 0x40, 0x78, 0x40, 0x40, 0x7C, 0x00, 0x00
0x7C, 0x40, 0x78, 0x40, 0x40, 0x40, 0x00, 0x00
0x38, 0x44, 0x80, 0x9C, 0x44, 0x38, 0x00, 0x00
0x42, 0x42, 0x7E, 0x42, 0x42, 0x42, 0x00, 0x00
0x3E, 0x08, 0x08, 0x08, 0x08, 0x3E, 0x00, 0x00
0x1C, 0x04, 0x04, 0x04, 0x44, 0x38, 0x00, 0x00
0x44, 0x48, 0x50, 0x70, 0x48, 0x44, 0x00, 0x00
0x40, 0x40, 0x40, 0x40, 0x40, 0x7E, 0x00, 0x00
0x41, 0x63, 0x55, 0x49, 0x41, 0x41, 0x00, 0x00
0x42, 0x62, 0x52, 0x4A, 0x46, 0x42, 0x00, 0x00
0x1C, 0x22, 0x22, 0x22, 0x22, 0x1C, 0x00, 0x00
0x78, 0x44, 0x78, 0x40, 0x40, 0x40, 0x00, 0x00
0x1C, 0x22, 0x22, 0x22, 0x22, 0x1C, 0x02, 0x00
0x78, 0x44, 0x78, 0x50, 0x48, 0x44, 0x00, 0x00
0x1C, 0x22, 0x10, 0x0C, 0x22, 0x1C, 0x00, 0x00
0x7F, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00
0x42, 0x42, 0x42, 0x42, 0x42, 0x3C, 0x00, 0x00
0x81, 0x42, 0x42, 0x24, 0x24, 0x18, 0x00, 0x00
0x41, 0x41, 0x49, 0x55, 0x63, 0x41, 0x00, 0x00
0x42, 0x24, 0x18, 0x18, 0x24, 0x42, 0x00, 0x00
0x41, 0x22, 0x14, 0x08, 0x08, 0x08, 0x00, 0x00
0x7E, 0x04, 0x08, 0x10, 0x20, 0x7E, 0x00, 0x00
0x38, 0x20, 0x20, 0x20, 0x20, 0x38, 0x00, 0x00
0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x00, 0x00
0x38, 0x08, 0x08, 0x08, 0x08, 0x38, 0x00, 0x00
0x10, 0x28, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
0x00, 0x00, 0x00, 0x00, 0x00, 0x7E, 0x00, 0x00
0x10, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
0x00, 0x3C, 0x02, 0x3E, 0x46, 0x3A, 0x00, 0x00
0x40, 0x40, 0x7C, 0x42, 0x62, 0x5C, 0x00, 0x00
0x00, 0x00, 0x1C, 0x20, 0x20, 0x1C, 0x00, 0x00
0x02, 0x02, 0x3E, 0x42, 0x46, 0x3A, 0x00, 0x00
0x00, 0x3C, 0x42, 0x7E, 0x40, 0x3C, 0x00, 0x00
0x00, 0x18, 0x10, 0x38, 0x10, 0x10, 0x00, 0x00
0x00, 0x00, 0x34, 0x4C, 0x44, 0x34, 0x04, 0x38
0x20, 0x20, 0x38, 0x24, 0x24, 0x24, 0x00, 0x00
0x08, 0x00, 0x08, 0x08, 0x08, 0x08, 0x00, 0x00
0x08, 0x00, 0x18, 0x08, 0x08, 0x08, 0x08, 0x70
0x20, 0x20, 0x24, 0x28, 0x30, 0x2C, 0x00, 0x00
0x10, 0x10, 0x10, 0x10, 0x10, 0x18, 0x00, 0x00
0x00, 0x00, 0x66, 0x5A, 0x42, 0x42, 0x00, 0x00
0x00, 0x00, 0x2E, 0x32, 0x22, 0x22, 0x00, 0x00
0x00, 0x00, 0x3C, 0x42, 0x42, 0x3C, 0x00, 0x00
0x00, 0x00, 0x5C, 0x62, 0x42, 0x7C, 0x40, 0x40
0x00, 0x00, 0x3A, 0x46, 0x42, 0x3E, 0x02, 0x02
0x00, 0x00, 0x2C, 0x32, 0x20, 0x20, 0x00, 0x00
0x00, 0x1C, 0x20, 0x18, 0x04, 0x38, 0x00, 0x00
0x00, 0x10, 0x3C, 0x10, 0x10, 0x18, 0x00, 0x00
0x00, 0x00, 0x22, 0x22, 0x26, 0x1A, 0x00, 0x00
0x00, 0x00, 0x42, 0x42, 0x24, 0x18, 0x00, 0x00
0x00, 0x00, 0x81, 0x81, 0x5A, 0x66, 0x00, 0x00
0x00, 0x00, 0x42, 0x24, 0x18, 0x66, 0x00, 0x00
0x00, 0x00, 0x42, 0x22, 0x14, 0x08, 0x10, 0x60
0x00, 0x00, 0x3C, 0x08, 0x10, 0x3C, 0x00, 0x00
0x1C, 0x10, 0x30, 0x30, 0x10, 0x1C, 0x00, 0x00
0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x08, 0x00
0x38, 0x08, 0x0C, 0x0C, 0x08, 0x38, 0x00, 0x00
0x00, 0x00, 0x00, 0x32, 0x4C, 0x00, 0x00, 0x00
0x7F, 0x63, 0x5D, 0x7D, 0x73, 0x7F, 0x77, 0x00
};

#endif //FONT_H
