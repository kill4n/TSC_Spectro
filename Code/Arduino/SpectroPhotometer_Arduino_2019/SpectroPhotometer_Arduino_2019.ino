/**
   Spectro Pothometer with Arduino
   Creted by Crhistian Segura
   Change Log:
      Date    |   Version   | Description
   29.01.2019 |    2.0.0    | Creation Color SensorLib. Comments Added.
   30.01.2019 |    2.0.1    | Add White Led
   ********************************************************************
   Default Pinout
   (Sensor -> Arduino uno)
   -----------------------
   S0 -> 2
   S1 -> 3
   S2 -> 4
   S3 -> 5
   sensorOut -> 6

   Color Filters Sensor
   --------------------
   RED_SENS -> Red
   BLU_SENS -> Blue
   GRN_SENS -> Green
   CLR_SENS -> Clear (No filter)

   Output Frequency Scaling
   ------------------------
   FREQ_OFF -> Power down
   FREQ_002 -> 002%
   FREQ_020 -> 020%
   FREQ_100 -> 100%
 **/

#include "ColorSensor.h"

ColorSensor ColorS(2, 3, 4, 5, 6);

//RGB Led Strip Pinouts
#define LEDR 11
#define LEDG 10
#define LEDB 9
#define LEDW 7

// Variable to hold frequency
int frequency = 0;
// Delay for Read
int delayRead = 2;

void setup()
{
  ColorS.init();
  ColorS.setColor(BLU_SENS);
  ColorS.setFreqScale(FREQ_020);
  // Leds direction
  pinMode(LEDR, OUTPUT); pinMode(LEDG, OUTPUT); pinMode(LEDB, OUTPUT);
  // Setting frequency-scaling to 20%
  // Leds Default off
  digitalWrite(LEDR, LOW); digitalWrite(LEDG, LOW); digitalWrite(LEDB, LOW);
  // Defining serial port 9600 8N1
  Serial.begin(9600); delay(1000); //Serial.print("i:Start Program");
}
// Variable for hold recieve data
char tmp;

void loop() {
  if (Serial.available() > 0) { // Are bytes to read in Serial Port?
    // Read serial byte
    tmp = Serial.read();
    // Set Color to RGB LED Strip
    switch (tmp) {
      case 'R': digitalWrite(LEDR, HIGH); break;
      case 'r': digitalWrite(LEDR, LOW); break;
      case 'G': digitalWrite(LEDG, HIGH); break;
      case 'g': digitalWrite(LEDG, LOW); break;
      case 'B': digitalWrite(LEDB, HIGH); break;
      case 'b': digitalWrite(LEDB, LOW); break;
      case 'K': digitalWrite(LEDW, HIGH); break;
      case 'k': digitalWrite(LEDW, LOW); break;
      //Set color Filters
      case 'X': ColorS.setColor(RED_SENS); break;
      case 'Y': ColorS.setColor(BLU_SENS); break;
      case 'Z': ColorS.setColor(GRN_SENS); break;
      case 'W': ColorS.setColor(CLR_SENS); break;
      //Set Scales
      case '0': ColorS.setFreqScale(FREQ_OFF); break;
      case '1': ColorS.setFreqScale(FREQ_002); break;
      case '2': ColorS.setFreqScale(FREQ_020); break;
      case '3': ColorS.setFreqScale(FREQ_100); break;
      //Lectura de Dato
      case '@':
        // Reading the output frequency
        frequency = ColorS.readColor();
        // Printing the value on the serial monitor
        Serial.println(frequency);
        break;
      default: break;
    }
  }
  delay(delayRead);
}
