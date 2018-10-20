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
int potVal;			      	// variable to read the value from the analog pin

//Thumb
int numReadingsThumb = 10;
int readingsThumb[10];
int indexThumb = 0;
int sensorMaxThumb = 0;
int sensorMinThumb = 0;

//Index
int numReadingsIndex = 10;
int readingsIndex[10];
int indexIndex = 0;
int sensorMaxIndex = 0;
int sensorMinIndex = 0;

//Middle
int numReadingsMiddle = 10;
int readingsMiddle[10];
int indexMiddle = 0;
int sensorMaxMiddle = 0;
int sensorMinMiddle = 0;

//Ring
int numReadingsRing = 10;
int readingsRing[10];
int indexRing = 0;
int sensorMaxRing = 0;
int sensorMinRing = 0;

//Pinky
int numReadingsPinky = 10;
int readingsPinky[10];
int indexPinky = 0;
int sensorMaxPinky = 0;
int sensorMinPinky = 0;

//angles
int angleTHUMB;	// variable to hold the angle for the servo motor
int angleINDEX;       
int angleMIDDLE;      
int angleRING;       
int anglePINKY;       

void setup() 
{
	myServoTHUMB.attach(13); // attaches the servo Thumb
	myServoINDEX.attach(12); // Index
	myServoMIDDLE.attach(11);// Middle
	myServoRING.attach(10);  // Ring
	myServoPINKY.attach(9);  // Pinky
  
	Serial.begin(9600);

  //Thumb
  sensorMaxThumb = analogRead(A1);
  sensorMinThumb = sensorMaxThumb;

  //Index
  sensorMaxIndex = analogRead(A2);
  sensorMinIndex = sensorMaxIndex;

  //Middle
  sensorMaxMiddle = analogRead(A3);
  sensorMinMiddle = sensorMaxMiddle;

  //Ring
  sensorMaxRing = analogRead(A4);
  sensorMinRing = sensorMaxRing;

  //Pinky
  sensorMaxPinky = analogRead(A5);
  sensorMinPinky = sensorMaxPinky;
  
}

void loop() 
{
	potVal = analogRead(potPin); // read the value of the potentiometer
								               // print out the value to the Serial Monitor
	Serial.print("potVal: ");
	Serial.println(potVal);

	//scale the numbers from the pot
	angleTHUMB  = map(potVal, 0, 1023, 0, 179);
	angleINDEX  = map(potVal, 0, 1023, 0, 179);
	angleMIDDLE = map(potVal, 0, 1023, 0, 179);
	angleRING   = map(potVal, 0, 1023, 0, 179);
	anglePINKY  = map(potVal, 0, 1023, 0, 179);

	// print out the angle for the servo motor
	Serial.print("angleTHUMB: ");
	Serial.println(angleTHUMB);

	Serial.print("angleINDEX: ");
	Serial.println(angleINDEX);

	Serial.print("angleMIDDLE: ");
	Serial.println(angleMIDDLE);

	Serial.print("angleRING: ");
	Serial.println(angleRING);

	Serial.print("anglePINKY: ");
	Serial.println(anglePINKY);

	// set the servo position
	myServoTHUMB.write(angleTHUMB);
	myServoINDEX.write(angleINDEX); 
	myServoMIDDLE.write(angleMIDDLE);  
	myServoRING.write(angleRING);
	myServoPINKY.write(anglePINKY);
  
	// wait for the servo to get there
	delay(10);

  //Read funcs
	//ReadSensorTHUMB();
	//ReadSensorINDEX();
	ReadSensorMIDDLE();
	//ReadSensorRING();
	//ReadSensorPINKY();

  delay(1000);
}

void ReadSensorTHUMB()
{
  // MEASUREMENTS
  // every iteration of loop makes one additional measurement,
  // so the first 10 readings will display too low average
  int valueThumb = (((analogRead(A1)-512)*20*2.5)/1023)/4;
  readingsThumb[indexThumb] = valueThumb;
  indexThumb++;
  if (indexThumb >= numReadingsThumb) 
    indexThumb = 0;

  // DO SOME MATH
  if (valueThumb > sensorMaxThumb) 
    sensorMaxThumb = valueThumb;
  if (valueThumb < sensorMinThumb) 
    sensorMinThumb = valueThumb;

  //running average
  float totalThumb = 0;
  for (int i = 0; i < numReadingsThumb; i++) 
    totalThumb += readingsThumb[i];
  float averageThumb = totalThumb / numReadingsThumb;

  // OUTPUT TO SERIAL
  Serial.print("\tMIN Thumb:\t");
  Serial.print(sensorMinThumb);
  Serial.print("\tMAX Thumb :\t");
  Serial.print(sensorMaxThumb);
  Serial.print("\tAVG Thumb :\t");
  Serial.println(averageThumb, 1);  // 1 decimal

  delay(10);
}


void ReadSensorINDEX()
{
  // MEASUREMENTS
  // every iteration of loop makes one additional measurement,
  // so the first 10 readings will display too low average
  int valueIndex = (((analogRead(A2) - 512) * 20 * 2.5) / 1023)/4;
  readingsIndex[indexIndex] = valueIndex;
  indexIndex++;
  if (indexIndex >= numReadingsIndex) indexIndex = 0;

  // DO SOME MATH
  if (valueIndex > sensorMaxIndex) sensorMaxIndex = valueIndex;
  if (valueIndex < sensorMinIndex) sensorMinIndex = valueIndex;

  //running average
  float totalIndex = 0;
  for (int i = 0; i < numReadingsIndex; i++) totalIndex += readingsIndex[i];
  float averageIndex = totalIndex / numReadingsIndex;

  // OUTPUT TO SERIAL
  Serial.print("\tMIN Index :\t");
  Serial.print(sensorMinIndex);
  Serial.print("\tMAX Index :\t");
  Serial.print(sensorMaxIndex);
  Serial.print("\tAVG Index :\t");
  Serial.println(averageIndex, 1);  // 1 decimal
  
	delay(10);
}

void ReadSensorMIDDLE()
{
  // MEASUREMENTS
  // every iteration of loop makes one additional measurement,
  // so the first 10 readings will display too low average
  int valueMiddle = (((analogRead(A3) - 512) * 20 * 2.5) / 1023)/4;
  readingsMiddle[indexMiddle] = valueMiddle;
  indexMiddle++;
  if (indexMiddle >= numReadingsMiddle) indexMiddle = 0;

  // DO SOME MATH
  if (valueMiddle > sensorMaxMiddle) sensorMaxMiddle = valueMiddle;
  if (valueMiddle < sensorMinMiddle) sensorMinMiddle = valueMiddle;

  //running average
  float totalMiddle = 0;
  for (int i = 0; i < numReadingsMiddle; i++) totalMiddle += readingsMiddle[i];
  float averageMiddle = totalMiddle / numReadingsMiddle;

  // OUTPUT TO SERIAL
  Serial.print("\tMIN Middle :\t");
  Serial.print(sensorMinMiddle);
  Serial.print("\tMAX Middle :\t");
  Serial.print(sensorMaxMiddle);
  Serial.print("\tAVG Middle :\t");
  Serial.println(averageMiddle, 1);  // 1 decimal

	delay(10);
}

void ReadSensorRING()
{
  // MEASUREMENTS
  // every iteration of loop makes one additional measurement,
  // so the first 10 readings will display too low average
  int valueRing = (((analogRead(A4) - 512) * 20 * 2.5) / 1023)/4;
  readingsRing[indexRing] = valueRing;
  indexRing++;
  if (indexRing >= numReadingsRing) indexRing = 0;

  // DO SOME MATH
  if (valueRing > sensorMaxRing) sensorMaxRing = valueRing;
  if (valueRing < sensorMinRing) sensorMinRing = valueRing;

  //running average
  float totalRing = 0;
  for (int i = 0; i < numReadingsRing; i++) totalRing += readingsRing[i];
  float averageRing = totalRing / numReadingsRing;

  // OUTPUT TO SERIAL
  Serial.print("\tMIN Ring :\t");
  Serial.print(sensorMinRing);
  Serial.print("\tMAX Ring :\t");
  Serial.print(sensorMaxRing);
  Serial.print("\tAVG Ring :\t");
  Serial.println(averageRing, 1);  // 1 decimal
  
  delay(10);
}

void ReadSensorPINKY()
{
  // MEASUREMENTS
  // every iteration of loop makes one additional measurement,
  // so the first 10 readings will display too low average
  int valuePinky = (((analogRead(A5) - 512) * 20 * 2.5) / 1023)/4;
  readingsPinky[indexPinky] = valuePinky;
  indexPinky++;
  if (indexPinky >= numReadingsPinky) indexPinky = 0;

  // DO SOME MATH
  if (valuePinky > sensorMaxPinky) sensorMaxPinky = valuePinky;
  if (valuePinky < sensorMinPinky) sensorMinPinky = valuePinky;

  //running average
  float totalPinky = 0;
  for (int i = 0; i < numReadingsPinky; i++) totalPinky += readingsPinky[i];
  float averagePinky = totalPinky / numReadingsPinky;

  // OUTPUT TO SERIAL
  Serial.print("\tMIN Pinky :\t");
  Serial.print(sensorMinPinky);
  Serial.print("\tMAX Pinky :\t");
  Serial.print(sensorMaxPinky);
  Serial.print("\tAVG Pinky :\t");
  Serial.println(averagePinky, 1);  // 1 decimal
  
	delay(10);
}
