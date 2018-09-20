# inMoov connect with Leap Motion Controller 

Well, this project have focus for right hand, part of the [3D printed life-size robot](http://inmoov.fr/). I want to controll that hand with my hand. So, for this intent i use [Leap Motion Contrller](https://www.leapmotion.com/). 

# What I use :

  - Leap Motion Controller
  - Right hand of inMoov robot
  - [Arduino Mega 2560](https://store.arduino.cc/arduino-mega-2560-rev3)
  - Visual Studio 2017 IDE for Windows

What have inMoov hand : 
  - 7 x Servo Motors FS5106B
  - Some cords
  - And many calebls

Before you start, you must have :
 * Drivers for Leap Motion and Leap Motion SDK (all information you can get of [this](https://developer.leapmotion.com/documentation/))
 * If you white on C#, you must to download [V3 Software](https://developer.leapmotion.com/releases/leap-motion-orion-321) and include ```LeapCSharp.NET4.0.dll``` or ```LeapCSharp.NET4.5.dll```.
 * For some fun you can see what`s hapend in ```Leap Motion Visualizer``` or  ```Leap Motion Diagnostic Visualizer``` .

I start with [this](https://developer-archive.leapmotion.com/documentation/csharp/devguide/Project_Setup.html) .

Now I'm developing a program that accepts the coordinates of my true hand and makes the artificial hand stand in the same way.
To this end, I started with servo motors that I am limiting through ACS712. This module is to judge the minimum and maximum values of the currents flowing through the servo that I will see through a simple example with a potentiometer.
