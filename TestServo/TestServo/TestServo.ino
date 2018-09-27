/*
 Name:		TestServo.ino
 Created:	9/12/2018 10:38:10 AM
 Author:	MIHAELA
*/

#include <Servo.h>
Servo myServoTest;
Servo myServoTHUMB;  
Servo myServoINDEX;  
Servo myServoMIDDLE;  
Servo myServoRING;
Servo myServoPINKY;
  
int const potPin = A0;  // analog pin used to connect the potentiometer
int potVal;				// variable to read the value from the analog pin

int angleTest;
int angleTHUMB;				// variable to hold the angle for the servo motor
int angleINDEX;       
int angleMIDDLE;      
int angleRING;       
int anglePINKY;       

void setup() 
{
	myServoTHUMB.attach(13);                 // attaches the servo on pin 9 to the servo object
  myServoINDEX.attach(12);  
  myServoMIDDLE.attach(11); 
  myServoRING.attach(10);
  myServoPINKY.attach(9);
  myServoTest.attach(8);
	
	Serial.begin(9600);
}

void loop() 
{
	potVal = analogRead(potPin); // read the value of the potentiometer
								               // print out the value to the Serial Monitor
	Serial.print("potVal: ");
	Serial.println(potVal);

	// scale the numbers from the pot
	//angleTHUMB = map(potVal, 0, 760, 0, 290);
  //angleINDEX = map(potVal, 0, 780, 0, 179);
  //angleMIDDLE = map(potVal, 0, 905, 0, 355);
  //angleRING = map(potVal, 0, 865, 0, 300);
  //anglePINKY = map(potVal, 0, 937, 0, 320);
  angleTest = map(potVal, 0, 760, 0, 290);

	// print out the angle for the servo motor
	//Serial.print("angleTHUMB: ");
	//Serial.println(angleTHUMB);

  //Serial.print("angleINDEX: ");
  //Serial.println(angleINDEX);

  //Serial.print("angleMIDDLE: ");
  //Serial.println(angleMIDDLE);

  //Serial.print("angleRING: ");
  //Serial.println(angleRING);

  //Serial.print("anglePINKY: ");
  //Serial.println(anglePINKY);

  Serial.print("ANGLE TEST : ");
  Serial.println(angleTest);

	// set the servo position
	//myServoTHUMB.write(angleTHUMB);
  //myServoINDEX.write(angleINDEX); 
  //myServoMIDDLE.write(angleMIDDLE);  
  //myServoRING.write(angleRING);
  //myServoPINKY.write(anglePINKY);
  myServoTest.write(angleTest);
  
	// wait for the servo to get there
	delay(1);

	//ReadSensor();
}

void ReadSensor()
{
  float value = 0;

  for(int i = 0; i < 1000; i++) 
  { 
    //DC Current Sensor ACS712 20V
    value = ((analogRead(A1)-512)*20*2.5)/1023;
    delay(10);
  }

  Serial.print("Amp: ");
  Serial.println(value);  

  delay(10);
}
