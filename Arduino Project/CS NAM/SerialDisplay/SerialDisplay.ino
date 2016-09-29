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

#define ledPin1 2
#define ledPin2 3
#define ledPin3 4
#define ledPin4 5
#define ledPin5 6
#define ledPin6 7

void setup()
{
  pinMode(ledPin1,OUTPUT);
  pinMode(ledPin2,OUTPUT);
  pinMode(ledPin3,OUTPUT);
  pinMode(ledPin4,OUTPUT);
  pinMode(ledPin5,OUTPUT);
  pinMode(ledPin6,OUTPUT);
  
  lcd.init();                      // initialize the lcd 
  lcd.backlight();
  Serial.begin(115200);
}

void loop()
{
  // when characters arrive over the serial port...
  if (Serial.available()) {
    // wait a bit for the entire message to arrive
    delay(100);
    // read all the available characters
    String tmp = "";
    while (Serial.available() > 0) {
      String value = Serial.readString(); 
      tmp+= value;
    }
    process(tmp);
  }
}
void process(String tmp){ 
  Serial.println(tmp);
  if(tmp == "11"){
      digitalWrite(ledPin1,HIGH);
   }
   else if(tmp == "21"){
      digitalWrite(ledPin1,LOW);
   }
   else if(tmp == "12"){
      digitalWrite(ledPin2,HIGH);
   }
   else if(tmp == "22"){
      digitalWrite(ledPin2,LOW);
   }
   else if(tmp == "13"){
      digitalWrite(ledPin3,HIGH);
   }
   else if(tmp == "23"){
      digitalWrite(ledPin3,LOW);
   }
   else if(tmp == "14"){
      digitalWrite(ledPin4,HIGH);
   }
   else if(tmp == "24"){
      digitalWrite(ledPin4,LOW);
   }
   else if(tmp == "15"){
      digitalWrite(ledPin5,HIGH);
   }
   else if(tmp == "25"){
      digitalWrite(ledPin5,LOW);
   }
   else if(tmp == "16"){
      digitalWrite(ledPin6,HIGH);
   }
   else if(tmp == "26"){
      digitalWrite(ledPin6,LOW);
   }
   else{
    // clear the screen
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Server started");
    lcd.setCursor(0,1);
    // display each character to the LCD
    lcd.print(tmp);
  }
}

