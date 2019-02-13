/**
   ColorSensor.h - Library for interact with color ColorSensor
   Creted by Crhistian Segura
   Change Log:
      Date    |   Version   | Description
   29.01.2019 |    1.0.0    | Creation Lib.
   30.01.2019 |    1.0.1    | Add timeOut for reading.
*/
#ifndef COLORSENSOR_H
#define COLORSENSOR_H
#include "Arduino.h"

enum ColorFilter {
  RED_SENS = 1 << 0,
  BLU_SENS = 1 << 1,
  CLR_SENS = 1 << 2,
  GRN_SENS = 1 << 3
};

enum FreqScale {
  FREQ_OFF = 1 << 0,
  FREQ_002 = 1 << 1,
  FREQ_020 = 1 << 2,
  FREQ_100 = 1 << 3
};

class ColorSensor {
  public:
    ColorSensor(int S0 , int S1 , int S2 , int S3 , int SOut);
    void init();
    void setColor(ColorFilter filt);
    void setFreqScale(FreqScale frequencyScale);
    int readColor();
    void setTimeOut(long timeOut);
  private:
    int s0, s1, s2, s3, sOut;
    int _frequency = 0;
    long _timeOut = 100000;
};

#endif //COLORSENSOR_H
