/*
 * Nguyen Hoang Chuong
 * Turn on/ off relay with bluetooth on smart phone
 */
#define outPin3 3 // set pin numbers:
#define outPin4 4 // set pin numbers:
#define outPin5 5 // set pin numbers:
#define outPin6 6 // set pin numbers:
#define outPin7 7 // set pin numbers:
#define outPin8 8 // set pin numbers:

byte pin3 = 101;
byte pin4 = 102;
byte pin5 = 103;
byte pin6 = 104;
byte pin7 = 105;
byte pin8 = 106;

void setup() {
  pinMode(outPin3, OUTPUT);//1
  pinMode(outPin4, OUTPUT);//2
  pinMode(outPin5, OUTPUT);//3
  pinMode(outPin6, OUTPUT);//4
  pinMode(outPin7, OUTPUT);//5
  pinMode(outPin8, OUTPUT);//6

  digitalWrite(outPin3, HIGH);
  digitalWrite(outPin4, HIGH);
  digitalWrite(outPin5, HIGH);
  digitalWrite(outPin6, HIGH);
  digitalWrite(outPin7, HIGH);
  digitalWrite(outPin8, HIGH);
  
  Serial.begin(9600);
}

void synch(){
  String tmp = "";
  if(pin3 == 111){  
    tmp += "111~";
    //delay(100);
  }
  if(pin4 == 112){  
     tmp += "112~";
    //delay(100);
  }
  if(pin5 == 113){  
    tmp += "113~";
    //delay(100);
  }
  if(pin6 == 114){  
     tmp += "114~";
    //delay(100);
  }
  if(pin7 == 115){  
    tmp += "115~";
    //delay(100);
  }
  if(pin8 == 116){  
     tmp += "116~";
    //delay(100);
  }
  Serial.println(tmp);
}

void loop() {
   
  // when characters arrive over the serial port...
  if (Serial.available()) {
    // wait a bit for the entire message to arrive
    delay(100);

    // read all the available characters
    while (Serial.available() > 0) {
      byte temp = Serial.read();  
      //Serial.write(temp);
      switch(temp){
        case 200:
          synch();
          break;
        
        case 111:    
          digitalWrite(outPin3, LOW);
          pin3 = 111;
          break;
        case 101:    
          digitalWrite(outPin3, HIGH);
          pin3 = 101;
          break;
        
        case 112:    
          digitalWrite(outPin4, LOW);
          pin4 = 112;
          break;
        case 102:    
          digitalWrite(outPin4, HIGH);
          pin4 = 102;
          break;
        
        case 113:    
          digitalWrite(outPin5, LOW);
          pin5 = 113;
          break;
        case 103:    
          digitalWrite(outPin5, HIGH);
          pin5 = 103;
          break;
        
        case 114:    
          digitalWrite(outPin6, LOW);
          pin6 = 114;
          break;
        case 104:    
          digitalWrite(outPin6, HIGH);
          pin6 = 104;
          break;
        
        case 115:    
          digitalWrite(outPin7, LOW);
          pin7 = 115;
          break;
        case 105:    
          digitalWrite(outPin7, HIGH);
          pin7 = 105;
          break;
       
        case 116:    
          digitalWrite(outPin8, LOW);
          pin8 = 116;
          break;
        case 106:    
          digitalWrite(outPin8, HIGH);
          pin8 = 106;
          break;
      }      
    }
  }
}

