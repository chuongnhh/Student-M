/*
 * Nguyen Hoang Chuong
 * Turn on/ off relay with bluetooth on smart phone
 */

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

void setup()
{
  // initialize the LED pin as an output:
  pinMode(outPin2, OUTPUT);//1
  pinMode(outPin3, OUTPUT);//2
  pinMode(outPin4, OUTPUT);//3
  pinMode(outPin5, OUTPUT);//4
  pinMode(outPin6, OUTPUT);//5
  pinMode(outPin7, OUTPUT);//6

  digitalWrite(outPin2, HIGH);
  digitalWrite(outPin3, HIGH);
  digitalWrite(outPin4, HIGH);
  digitalWrite(outPin5, HIGH);
  digitalWrite(outPin6, HIGH);
  digitalWrite(outPin7, HIGH);
  
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
          break;
        
        case 11:    
          digitalWrite(outPin2, LOW);
          pin2 = 11;
          break;
        case 21:    
          digitalWrite(outPin2, HIGH);
          pin2 = 21;
          break;
        
        case 12:    
          digitalWrite(outPin3, LOW);
          pin3 = 12;
          break;
        case 22:    
          digitalWrite(outPin3, HIGH);
          pin3 = 22;
          break;
        
        case 13:    
          digitalWrite(outPin4, LOW);
          pin4 = 13;
          break;
        case 23:    
          digitalWrite(outPin4, HIGH);
          pin4 = 23;
          break;
        
        case 14:    
          digitalWrite(outPin5, LOW);
          pin5 = 14;
          break;
        case 24:    
          digitalWrite(outPin5, HIGH);
          pin5 = 24;
          break;
        
        case 15:    
          digitalWrite(outPin6, LOW);
          pin6 = 15;
          break;
        case 25:    
          digitalWrite(outPin6, HIGH);
          pin6 = 25;
          break;
       
        case 16:    
          digitalWrite(outPin7, LOW);
          pin7 = 16;
          break;
        case 26:    
          digitalWrite(outPin7, HIGH);
          pin7 = 26;
          break;
      }      
    }
  }
}
