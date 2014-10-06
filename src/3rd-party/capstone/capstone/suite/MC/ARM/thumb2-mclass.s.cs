# CS_ARCH_ARM, CS_MODE_THUMB, 
0xef,0xf3,0x00,0x80 = mrs r0, apsr
0xef,0xf3,0x01,0x80 = mrs r0, iapsr
0xef,0xf3,0x02,0x80 = mrs r0, eapsr
0xef,0xf3,0x03,0x80 = mrs r0, xpsr
0xef,0xf3,0x05,0x80 = mrs r0, ipsr
0xef,0xf3,0x06,0x80 = mrs r0, epsr
0xef,0xf3,0x07,0x80 = mrs r0, iepsr
0xef,0xf3,0x08,0x80 = mrs r0, msp
0xef,0xf3,0x09,0x80 = mrs r0, psp
0xef,0xf3,0x10,0x80 = mrs r0, primask
0xef,0xf3,0x11,0x80 = mrs r0, basepri
0xef,0xf3,0x12,0x80 = mrs r0, basepri_max
0xef,0xf3,0x13,0x80 = mrs r0, faultmask
0xef,0xf3,0x14,0x80 = mrs r0, control
0x80,0xf3,0x00,0x88 = msr apsr, r0
0x80,0xf3,0x00,0x88 = msr apsr, r0
0x80,0xf3,0x00,0x84 = msr apsr_g, r0
0x80,0xf3,0x00,0x8c = msr apsr_nzcvqg, r0
0x80,0xf3,0x01,0x88 = msr iapsr, r0
0x80,0xf3,0x01,0x88 = msr iapsr, r0
0x80,0xf3,0x01,0x84 = msr iapsr_g, r0
0x80,0xf3,0x01,0x8c = msr iapsr_nzcvqg, r0
0x80,0xf3,0x02,0x88 = msr eapsr, r0
0x80,0xf3,0x02,0x88 = msr eapsr, r0
0x80,0xf3,0x02,0x84 = msr eapsr_g, r0
0x80,0xf3,0x02,0x8c = msr eapsr_nzcvqg, r0
0x80,0xf3,0x03,0x88 = msr xpsr, r0
0x80,0xf3,0x03,0x88 = msr xpsr, r0
0x80,0xf3,0x03,0x84 = msr xpsr_g, r0
0x80,0xf3,0x03,0x8c = msr xpsr_nzcvqg, r0
0x80,0xf3,0x05,0x88 = msr ipsr, r0
0x80,0xf3,0x06,0x88 = msr epsr, r0
0x80,0xf3,0x07,0x88 = msr iepsr, r0
0x80,0xf3,0x08,0x88 = msr msp, r0
0x80,0xf3,0x09,0x88 = msr psp, r0
0x80,0xf3,0x10,0x88 = msr primask, r0
0x80,0xf3,0x11,0x88 = msr basepri, r0
0x80,0xf3,0x12,0x88 = msr basepri_max, r0
0x80,0xf3,0x13,0x88 = msr faultmask, r0
0x80,0xf3,0x14,0x88 = msr control, r0
