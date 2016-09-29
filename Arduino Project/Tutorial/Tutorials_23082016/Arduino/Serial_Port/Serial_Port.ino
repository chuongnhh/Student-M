
int inByte = 0;         // incoming serial byte

void setup() {
  // start serial port at 9600 bps:
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }

  pinMode(2, OUTPUT);   // digital sensor is on digital pin 2
  pinMode(3, OUTPUT);
 }

void loop() {
  // read from port 1, send to port 0:
  /*if (Serial.available()) {
    int inByte = Serial.read();
    delay(1);
    Serial.write(inByte);
    if(inByte == 49)
      digitalWrite(2, HIGH);
    else if(inByte == 48)
      digitalWrite(2, LOW);
  }*/
  //();
  Serial.print("hello, world!");
  delay(1000);
}

void Led(){
  //if(inByte == 49)
      digitalWrite(2, HIGH);
      delay(1000);
  //else if(inByte == 48)
      digitalWrite(2, LOW);
      delay(1000);
}

