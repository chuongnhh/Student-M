// Date and time functions using a DS1307 RTC connected via I2C and Wire lib
// A5->SCL
// SDA->A4
#include <Wire.h>
#include "RTClib.h"
//#include <LiquidCrystal_I2C.h>

//LiquidCrystal_I2C lcd(0x27, 2, 1, 0, 4, 5, 6, 7, 3, POSITIVE);

RTC_DS1307 rtc;

void setup () {
    //lcd.begin(16,2);  

    Serial.begin(57600);
    #ifdef AVR
    Wire.begin();
    #else
    Wire1.begin(); // Shield I2C pins connect to alt I2C bus on Arduino Due
    #endif
    rtc.begin();
  
    if (! rtc.isrunning()) {
      Serial.println("RTC is NOT running!");
      // following line sets the RTC to the date & time this sketch was compiled
      rtc.adjust(DateTime(F(__DATE__), F(__TIME__)));
    }
}

void loop () {
    DateTime now = rtc.now();
    
    Serial.print(now.year(), DEC);
    Serial.print('/');
    Serial.print(now.month(), DEC);
    Serial.print('/');
    Serial.print(now.day(), DEC);
    
    //lcd.setCursor(0,0); 
    //lcd.print(now.day(), DEC);
    //lcd.print('/');  
    //lcd.print(now.month(), DEC);
    //lcd.print('/');
    //lcd.print(now.year(), DEC);
    
    Serial.print(' ');
    Serial.print(now.hour(), DEC);
    Serial.print(':');
    Serial.print(now.minute(), DEC);
    Serial.print(':');
    Serial.print(now.second(), DEC);   
    Serial.println();
    
    //lcd.setCursor(0,1); 
    //lcd.print(now.hour(), DEC);
    //lcd.print(':');
    //lcd.print(now.minute(), DEC);
    //lcd.print(':');
    //lcd.print(now.second(), DEC);
   
    delay(1000);
}
