/*
 * Servo.h
 *
 * Created: 26-Dec-12 1:42:27 PM
 *  Author: Mayur
 */ 


#ifndef SERVO_H_
#define SERVO_H_

unsigned int servo_value1,servo_value2,servo_value3,servo_value4,servo_value5,servo_value6,servo_value7;
unsigned char set = 0;

void servo_init(void)//Initialize servo
{
	DDRJ  = 0xFF;//Data direction = input
	PORTJ = 0;
	TCCR1A = 0;//Timer counter control register
	TCCR1B = 0;
	TCCR1C = 0;
	TCNT1=28673;//Timer Counter
	ICR1=36863;
	TCCR1B = (1<<CS10);//No prescaling
	TIMSK1 = 0x0F;//Timer Interrupt set
	sei();// Enable Global Interrupt 
}
//Get 400HZ(i.e 2.5ms) ,so 1/F=1/14745600 =6.7816840277777777777777777777778e-8
//(0.025/6.7816840277777777777777777777778e-8)-1=36863(i.e  0-36863 is 0-2.5ms)
//Set Timer Counter value =65535-36863=28673
//400HZ/8=50HZ ,so each motor gets 50 cycle/second
void servo1(unsigned char angle)                
{
	servo_value1=36045+(163 * angle);
//Servo Value=Timer Reload(28673)+Required Pulse value
//Required Pulse value=36863/2.5=14745*Required pulse Time(eg. 0.5ms)
//For 0.5ms  14745*0.5=7372.6
//Constant value =(2.5ms-0.5ms) i.e (36863-7372.6)/180=163
//servo_value1=37520+(131 * angle);//for 0.6ms
//servo_value1 = 0xA999 + (81 * angle); //for 1ms
}

void servo2(unsigned char angle)                
{
	servo_value2= 36045+(163 * angle);
}

void servo3(unsigned char angle)                
{
	servo_value3=36045+(163 * angle);	
}

void servo4(unsigned char angle)                
{
	servo_value4=36045+(163 * angle);
}

void servo5(unsigned char angle)                
{
	servo_value5=36045+(163 * angle);
}

void servo6(unsigned char angle)              
{
	servo_value6=36045+(163 * angle);
}

void servo7(unsigned char angle)
{
	servo_value7=36045+(163 * angle);
}

ISR(TIMER1_COMPA_vect)//Interrupt is called when OCRA Matches Timer Counter
{  
	 //Reset the servo
	if (set== 0) PORTJ =PORTJ & 0xFD;
	if (set== 1)  PORTJ =PORTJ &  0xFB;
	if (set== 2)  PORTJ =PORTJ &  0x7F;	
	
}

ISR(TIMER1_COMPB_vect)
{
	if (set== 0)  PORTJ =PORTJ &  0xF7;
	if (set== 1)  PORTJ = PORTJ & 0xEF;
}
ISR(TIMER1_COMPC_vect)
{
	if (set== 0) PORTJ =PORTJ &  0xDF;
	if (set== 1) PORTJ =PORTJ &  0xBF;
}
ISR(TIMER1_OVF_vect)//Timer overflow interrupt
{
	TCNT1=28673;//Reload Timer value
	set++;
	if (set>7)
	{
		set = 0;
	}

	if (set== 0)
	{
		//Set pin High of servo
		PORTJ =PORTJ | 0x02;
		PORTJ =PORTJ | 0x08;
		PORTJ =PORTJ | 0x20;
		//Output compare Register 
		OCR1A=servo_value1;
		OCR1B=servo_value3;
		OCR1C=servo_value5;
	}
	
	if (set== 1)
	{
		PORTJ =PORTJ | 0x04;
		PORTJ =PORTJ | 0x10;
		PORTJ =PORTJ | 0x40;
		
		OCR1A=servo_value2;
		OCR1B=servo_value4;
		OCR1C=servo_value6;
	}

	if (set== 2)
	{
		PORTJ =PORTJ | 0x80;
		OCR1A=servo_value7;

	}
	
}



#endif /* SERVO_H_ */