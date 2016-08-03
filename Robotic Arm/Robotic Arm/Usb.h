/*
 * Usb.h
 *
 * Created: 20-Dec-12 10:33:25 PM
 *  Author: Mayur
 */ 


#ifndef USB_H_
#define USB_H_
#define buffer_size 3
 unsigned char buffer[buffer_size]="";
 unsigned char count=0;
 unsigned char setValue=0;
inline void usb_init()
{
	//USART Control and Status Register
	UCSR0B |= (1 << RXEN0) | (1 << TXEN0)| (1<<RXCIE0);   // It enables transmitter/reciever and Interrupt
	UCSR0C |= (1 << UCSZ00) | (1 << UCSZ01);   //Selects  the data block size of  8bit
	//USART Baud Rate Calculation=(f_cpu/(16*baudrate_required))-1 i.e 115200
	UBRR0L = 0x07;
	UBRR0H = 0x00;
	sei();//Enable Interrupt
}


unsigned int usb_sendchar(unsigned char data)
{
	UDR0=data;//USART data register
	while ((UCSR0A & (1 << TXC0)) == 0);//Wait till the buffer is empty
	_delay_ms(10);		
}

void usb_sendstring(char * st)//Send String to PC
{
	while(*st)
	{
		usb_sendchar(*st++);
	}
}
 ISR (USART0_RX_vect)//USART Reciever Interrupt(Recieve from PC)
 {
	 
	 buffer[count++]=UDR0;//Recieve data in buffer
	 _delay_us(1);//Delay for next data to be recieved
	 
	  if(count==buffer_size)//Condition for buffer overflow
		 {
			 count=0;//Reset buffer
			 setValue++;
			 switch(setValue)//sends data to servo motor
			 {
				 case 1:
				 servo1(atoi(buffer));
				 break;
				 case 2:
				 servo2(atoi(buffer));
				 break;
				 case 3:
				 servo3(atoi(buffer));
				 break;
				 case 4:
				 servo4(atoi(buffer));
				 servo5(atoi(buffer));
				 break;
				 case 5:
				 servo6(atoi(buffer));
				 break;
				 case 6:
				 servo7(atoi(buffer));
				 setValue=0;
				 break;
				 
			 }
			
		 
		 }
	 
 }

#endif /* USB_H_ */