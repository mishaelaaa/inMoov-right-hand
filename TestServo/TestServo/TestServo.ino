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
	Vcc = readVcc() / 1000.0;
	Serial.print("Vcc: ");
	Serial.print(Vcc);

	long average = 0;
	for (int i = 0; i < 100; i++)
	{
		average = average + analogRead(A0);
		delay(100);
	}
	average = average / 100;

	float sensorValue = average * (5.0 / 1023.0);
	Serial.print("Sense: ");
	Serial.print(sensorValue, 3);

	float acoffset = Vcc / 2.0;
	Serial.print("Offst: ");
	Serial.print(acoffset, 3);

	float sensitivity = 0.185 * (Vcc / 5.0);
	Serial.print("Sensi: ");
	Serial.print(sensitivity, 4);

	float amps = (sensorValue-acoffset) / sensitivity;
	Serial.print("Amperes: ");
	Serial.print (amps);
	Serial.println(" … ");

	delay(1000);
}

long readVcc()
{
	// Read 1.1V reference against AVcc
	// set the reference to Vcc and the measurement to the internal 1.1V reference
#if defined(__AVR_ATmega32U4__) || defined(__AVR_ATmega1280__) || defined(__AVR_ATmega2560__)
	ADMUX = _BV(REFS0) | _BV(MUX4) | _BV(MUX3) | _BV(MUX2) | _BV(MUX1);

#elif defined (__AVR_ATtiny24__) || defined(__AVR_ATtiny44__) || defined(__AVR_ATtiny84__)
	ADMUX = _BV(MUX5) | _BV(MUX0);

#elif defined (__AVR_ATtiny25__) || defined(__AVR_ATtiny45__) || defined(__AVR_ATtiny85__)
	ADMUX = _BV(MUX3) | _BV(MUX2);

#else
	ADMUX = _BV(REFS0) | _BV(MUX3) | _BV(MUX2) | _BV(MUX1);

#endif

	delay(2);								// Wait for Vref to settle
	ADCSRA |= _BV(ADSC);					// Start conversion
	while (bit_is_set(ADCSRA, ADSC));		// measuring

	uint8_t low = ADCL;			// must read ADCL first – it then locks ADCH
	uint8_t high = ADCH;		// unlocks both

	long result = (high << 8) | low;

	result = 1125300L / result; // Calculate Vcc (in mV); 1125300 = 1.1*1023*1000
	return result;				// Vcc in millivolts
}