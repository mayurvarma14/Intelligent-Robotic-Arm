/*
 * Robotic_Arm.c
 *
 * Created: 19-Dec-12 11:58:04 AM
 *  Author: Mayur
 */
#include<stdio.h>
#include<stdlib.h>
#include<util/delay.h>
#include<avr/io.h>
#include<avr/interrupt.h>
#include<util/delay.h>
#include "servo.h"
#include "Usb.h"
#include<string.h>
#define  F_CPU 14745600UL
unsigned char c[5];

int main(void)
{
	usb_init();
 	servo_init();
	  _delay_ms(3000);
	  servo1(90);
	  servo2(90);
	  servo3(90);
	  servo4(90);
	  servo5(90);
	  servo6(90);
	  servo7(90);
 	while(1);

}
