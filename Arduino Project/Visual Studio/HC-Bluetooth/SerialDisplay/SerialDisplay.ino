/*
 * Displays text sent over the serial port (e.g. from the Serial Monitor) on
 * an attached LCD.
 * YWROBOT
 *Compatible with the Arduino IDE 1.0
 *Library version:1.1
 */
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,20,4);  // set the LCD address to 0x27 for a 16 chars and 2 line display
#define outPin 13 // set pin numbers:

void setup()
{
  // initialize the LED pin as an output:
  pinMode(outPin, OUTPUT);
  
  lcd.init();                      // initialize the lcd 
  lcd.backlight();
   // Print a message to the LCD.
  lcd.backlight();
  lcd.setCursor(0,0);
  lcd.print("Hello, world!");
  
  Serial.begin(9600);
}

void loop()
{
  // when characters arrive over the serial port...
  if (Serial.available()) {
    // wait a bit for the entire message to arrive
    delay(100);
    
    // clear the screen
    lcd.clear();
    lcd.setCursor(0,0);
    // read all the available characters
    while (Serial.available() > 0) {
      int temp = Serial.read();
      if (temp == 49) {
        digitalWrite(outPin, HIGH);
        lcd.print("Turned on!");
      } 
      else {
        digitalWrite(outPin, LOW);
        lcd.print("Turned off!");
      }
    }
  }
}
