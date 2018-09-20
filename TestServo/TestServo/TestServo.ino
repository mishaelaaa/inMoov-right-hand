/*
 Name:		TestServo.ino
 Created:	9/12/2018 10:38:10 AM
 Author:	MIHAELA
*/

#include <Servo.h>

Servo myServo;  
int const potPin = A0;  // analog pin used to connect the potentiometer
int potVal;				// variable to read the value from the analog pin
int angle;				// variable to hold the angle for the servo motor

void setup() 
{
	myServo.attach(9);                 // attaches the servo on pin 9 to the servo object
	Serial.begin(9600);
}

void loop() 
{
	potVal = analogRead(potPin); // read the value of the potentiometer
								               // print out the value to the Serial Monitor
	Serial.print("potVal: ");
	Serial.print(potVal);

	// scale the numbers from the pot
	angle = map(potVal, 0, 1023, 0, 179);

	// print out the angle for the servo motor
	Serial.print(", angle: ");
	Serial.println(angle);

	// set the servo position
	myServo.write(angle);

	// wait for the servo to get there
	delay(10);

	ReadSensor();
}

void ReadSensor()
{
  float value = 0;

  for(int i = 0; i < 1000; i++) 
  {
    value = ((analogRead(A1)-512)*20*2.5)/1023;
    delay(1);
  }

  Serial.print("Amp: ");
  Serial.println(value);  

  delay(10);
}
