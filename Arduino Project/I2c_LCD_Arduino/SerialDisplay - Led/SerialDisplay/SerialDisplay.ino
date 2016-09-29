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

#define outPin9 9 // set pin numbers:
#define outPin8 8 // set pin numbers:
#define outPin7 7 // set pin numbers:
#define outPin6 6 // set pin numbers:
#define outPin5 5 // set pin numbers:
#define outPin4 4 // set pin numbers:
#define outPin3 3 // set pin numbers:
#define outPin2 2 // set pin numbers:

byte pin2 = 21;
byte pin3 = 22;
byte pin4 = 23;
byte pin5 = 24;
byte pin6 = 25;
byte pin7 = 26;
byte pin8 = 27;
byte pin9 = 28;

void setup()
{
  // initialize the LED pin as an output:
  pinMode(outPin2, OUTPUT);//1
  pinMode(outPin3, OUTPUT);//2
  pinMode(outPin4, OUTPUT);//3
  pinMode(outPin5, OUTPUT);//4
  pinMode(outPin6, OUTPUT);//5
  pinMode(outPin7, OUTPUT);//6
  pinMode(outPin8, OUTPUT);//7
  pinMode(outPin9, OUTPUT);//8
  
  lcd.init(); // initialize the lcd 
  lcd.backlight();
   // Print a message to the LCD.
  lcd.setCursor(0,0);
  lcd.print("Hello, world!");
  
  Serial.begin(9600);
}

void synch(){
  if(pin2 == 11){  
    Serial.write(pin2);
    delay(100);
  }
  if(pin3 == 12){  
    Serial.write(pin3);
    delay(100);
  }
  if(pin4 == 13){  
    Serial.write(pin4);
    delay(100);
  }
  if(pin5 == 14){  
    Serial.write(pin5);
    delay(100);
  }
  if(pin6 == 15){  
    Serial.write(pin6);
    delay(100);
  }
  if(pin7 == 16){  
    Serial.write(pin7);
    delay(100);
  }
  if(pin8 == 17){  
    Serial.write(pin8);
    delay(100);
  }
  if(pin9 == 18){  
    Serial.write(pin9);
    delay(100);
  }
}

void loop()
{    
  // when characters arrive over the serial port...
  if (Serial.available()) {
    // wait a bit for the entire message to arrive
    delay(100);

    // read all the available characters
    while (Serial.available() > 0) {
      byte temp = Serial.read();  
      //Serial.write(temp);
      //lcd.print(temp);
      switch(temp){
        case 20:
          synch();
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("Synch done..");
          break;
        
        case 11:    
          digitalWrite(outPin2, HIGH);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("1. Turned on!");
          pin2 = 11;
          break;
        case 21:    
          digitalWrite(outPin2, LOW);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("1. Turned off!");
          pin2 = 21;
          break;
        
        case 12:    
          digitalWrite(outPin3, HIGH);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("2. Turned on!");
          pin3 = 12;
          break;
        case 22:    
          digitalWrite(outPin3, LOW);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("2. Turned off!");
          pin3 = 22;
          break;
        
        case 13:    
          digitalWrite(outPin4, HIGH);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("3. Turned on!");
          pin4 = 13;
          break;
        case 23:    
          digitalWrite(outPin4, LOW);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("3. Turned off!");
          pin4 = 23;
          break;
        
        case 14:    
          digitalWrite(outPin5, HIGH);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("4. Turned on!");
          pin5 = 14;
          break;
        case 24:    
          digitalWrite(outPin5, LOW);
          lcd.clear();
          lcd.print("4. Turned off!");
          pin5 = 24;
          break;
        
        case 15:    
          digitalWrite(outPin6, HIGH);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("5. Turned on!");
          pin6 = 15;
          break;
        case 25:    
          digitalWrite(outPin6, LOW);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("5. Turned off!");
          pin6 = 25;
          break;
       
        case 16:    
          digitalWrite(outPin7, HIGH);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("6. Turned on!");
          pin7 = 16;
          break;
        case 26:    
          digitalWrite(outPin7, LOW);
          lcd.clear();
          lcd.print("6. Turned off!");
          pin7 = 26;
          break;
        
        case 17:    
          digitalWrite(outPin8, HIGH);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("7. Turned on!");
          pin8 = 17;
          break;
        case 27:    
          digitalWrite(outPin8, LOW);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("7. Turned off!");
          pin8 = 27;
          break;
        
        case 18:    
          digitalWrite(outPin9, HIGH);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("8. Turned on!");
          pin9 = 18;
          break;
        case 28:    
          digitalWrite(outPin9, LOW);
          lcd.clear();
          lcd.setCursor(0,0);
          lcd.print("8. Turned off!");
          pin9 = 28;
          break;
      }      
    }
  }
}
