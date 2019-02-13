/**
   Color Sensor Library
   Creted by Crhistian Segura
   Change Log:
      Date    |   Version   | Description
   29.01.2019 |    1.0.0    | Creation Lib.
   30.01.2019 |    1.0.1    | Add timeOut for reading.
**/

#include "ColorSensor.h"

ColorSensor::ColorSensor(int S0, int S1, int S2, int S3, int SOut) {
  s0 = S0; s1 = S1; s2 = S2; s3 = S3; sOut = SOut;
}

void ColorSensor::init() {
  pinMode(s0, OUTPUT);
  pinMode(s1, OUTPUT);
  pinMode(s2, OUTPUT);
  pinMode(s3, OUTPUT);
  pinMode(sOut, INPUT);
}

void ColorSensor::setColor(ColorFilter filt) {
  switch (filt) {
    case RED_SENS: digitalWrite(s2, LOW); digitalWrite(s3, LOW); break;
    case BLU_SENS: digitalWrite(s2, LOW); digitalWrite(s3, HIGH); break;
    case CLR_SENS: digitalWrite(s2, HIGH); digitalWrite(s3, LOW); break;
    case GRN_SENS: digitalWrite(s2, HIGH); digitalWrite(s3, HIGH); break;
    default: break;
  }
  delay(10);
}

void ColorSensor::setFreqScale(FreqScale frequencyScale) {
  switch (frequencyScale) {
    case FREQ_OFF: digitalWrite(s0, LOW); digitalWrite(s1, LOW); break;
    case FREQ_002: digitalWrite(s0, LOW); digitalWrite(s1, HIGH); break;
    case FREQ_020: digitalWrite(s0, HIGH); digitalWrite(s1, LOW); break;
    case FREQ_100: digitalWrite(s0, HIGH); digitalWrite(s1, HIGH); break;
    default: break;
  }
  delay(10);
}

int ColorSensor::readColor() {
  _frequency = pulseIn(sOut, LOW, _timeOut);
  return _frequency;
}

void ColorSensor::setTimeOut(long timeOut) {
  _timeOut = timeOut;
}
