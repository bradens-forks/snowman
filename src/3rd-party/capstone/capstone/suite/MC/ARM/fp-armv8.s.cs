# CS_ARCH_ARM, CS_MODE_ARM, None
0xe0,0x3b,0xb2,0xee = vcvtt.f64.f16 d3, s1
0xcc,0x2b,0xf3,0xee = vcvtt.f16.f64 s5, d12
0x60,0x3b,0xb2,0xee = vcvtb.f64.f16 d3, s1
0x41,0x2b,0xb3,0xee = vcvtb.f16.f64 s4, d1
0xe0,0x3b,0xb2,0xae = vcvttge.f64.f16 d3, s1
0xcc,0x2b,0xf3,0xce = vcvttgt.f16.f64 s5, d12
0x60,0x3b,0xb2,0x0e = vcvtbeq.f64.f16 d3, s1
0x41,0x2b,0xb3,0xbe = vcvtblt.f16.f64 s4, d1
0xe1,0x1a,0xbc,0xfe = vcvta.s32.f32 s2, s3
0xc3,0x1b,0xbc,0xfe = vcvta.s32.f64 s2, d3
0xeb,0x3a,0xbd,0xfe = vcvtn.s32.f32 s6, s23
0xe7,0x3b,0xbd,0xfe = vcvtn.s32.f64 s6, d23
0xc2,0x0a,0xbe,0xfe = vcvtp.s32.f32 s0, s4
0xc4,0x0b,0xbe,0xfe = vcvtp.s32.f64 s0, d4
0xc4,0x8a,0xff,0xfe = vcvtm.s32.f32 s17, s8
0xc8,0x8b,0xff,0xfe = vcvtm.s32.f64 s17, d8
0x61,0x1a,0xbc,0xfe = vcvta.u32.f32 s2, s3
0x43,0x1b,0xbc,0xfe = vcvta.u32.f64 s2, d3
0x6b,0x3a,0xbd,0xfe = vcvtn.u32.f32 s6, s23
0x67,0x3b,0xbd,0xfe = vcvtn.u32.f64 s6, d23
0x42,0x0a,0xbe,0xfe = vcvtp.u32.f32 s0, s4
0x44,0x0b,0xbe,0xfe = vcvtp.u32.f64 s0, d4
0x44,0x8a,0xff,0xfe = vcvtm.u32.f32 s17, s8
0x48,0x8b,0xff,0xfe = vcvtm.u32.f64 s17, d8
0xab,0x2a,0x20,0xfe = vselge.f32 s4, s1, s23
0xa7,0xeb,0x6f,0xfe = vselge.f64 d30, d31, d23
0x80,0x0a,0x30,0xfe = vselgt.f32 s0, s1, s0
0x24,0x5b,0x3a,0xfe = vselgt.f64 d5, d10, d20
0x2b,0xfa,0x0e,0xfe = vseleq.f32 s30, s28, s23
0x08,0x2b,0x04,0xfe = vseleq.f64 d2, d4, d8
0x07,0xaa,0x58,0xfe = vselvs.f32 s21, s16, s14
0x2f,0x0b,0x11,0xfe = vselvs.f64 d0, d1, d31
0x00,0x2a,0xc6,0xfe = vmaxnm.f32 s5, s12, s0
0xae,0x5b,0x86,0xfe = vmaxnm.f64 d5, d22, d30
0x46,0x0a,0x80,0xfe = vminnm.f32 s0, s0, s12
0x49,0x4b,0x86,0xfe = vminnm.f64 d4, d6, d9
0xcc,0x3b,0xb6,0xae = vrintzge.f64 d3, d12
0xcc,0x1a,0xf6,0xee = vrintz.f32 s3, s24
0x40,0x5b,0xb6,0xbe = vrintrlt.f64 d5, d0
0x64,0x0a,0xb6,0xee = vrintr.f32 s0, s9
0x6e,0xcb,0xf7,0x0e = vrintxeq.f64 d28, d30
0x47,0x5a,0xb7,0x6e = vrintxvs.f32 s10, s14
0x44,0x3b,0xb8,0xfe = vrinta.f64 d3, d4
0x60,0x6a,0xb8,0xfe = vrinta.f32 s12, s1
0x44,0x3b,0xb9,0xfe = vrintn.f64 d3, d4
0x60,0x6a,0xb9,0xfe = vrintn.f32 s12, s1
0x44,0x3b,0xba,0xfe = vrintp.f64 d3, d4
0x60,0x6a,0xba,0xfe = vrintp.f32 s12, s1
0x44,0x3b,0xbb,0xfe = vrintm.f64 d3, d4
0x60,0x6a,0xbb,0xfe = vrintm.f32 s12, s1
0x10,0xda,0xf5,0xee = vmrs sp, mvfr2