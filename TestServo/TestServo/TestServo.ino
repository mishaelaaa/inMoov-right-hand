/*
 Name:		TestServo.ino
 Created:	9/12/2018 10:38:10 AM
 Author:	MIHAELA
*/

#include <Servo.h>

Servo myservo;  

int pos = 0;    // variable to store the servo position
float Vcc = 0;	// variable to Vcc

void setup() 
{
	myservo.attach(9);  // attaches the servo on pin 9 to the servo object
	Serial.begin(9600);
}

void loop() 
{
	for (pos = 0; pos <= 180; pos += 1) 
	{ // goes from 0 degrees to 180 degrees
										  // in steps of 1 degree
		myservo.write(pos);              // tell servo to go to position in variable 'pos'
		delay(15);                       // waits 15ms for the servo to reach the position
	}
	for (pos = 180; pos >= 0; pos -= 1)
	{ // goes from 180 degrees to 0 degrees
		myservo.write(pos);              // tell servo to go to position in variable 'pos'
		delay(15);                       // waits 15ms for the servo to reach the position
	}

	ReadSensor();
}

void ReadSensor()
{
  float value = 0;
  for(int i = 0; i < 1000; i++) 
  {
    value = ((analogRead(A0)-512)*20*2.5)/1023;
    delay(1);
  }
  Serial.println(value);  
}
