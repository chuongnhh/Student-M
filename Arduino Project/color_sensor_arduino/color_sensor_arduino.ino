/*  Arduino Color Sensing Tutorial     
 *  by Nguyen Hoang Chuong, https://www.facebook.com/chuongnhxx
 */

// defines pins numbers hc-rs04
#define trigPin 9
#define echoPin 10
// defines variables
long duration;
int distance;
// end hc-rs04
bool started = false;
 
#define S0 4
#define S1 5
#define S2 6
#define S3 7
#define sensorOut 3
int fre_RE = 0;
int fre_GR = 0;
int fre_BL = 0;

void setup() {
  // Set pin mode output
  pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin, INPUT); // Sets the echoPin as an Input

  pinMode(S0, OUTPUT);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(S3, OUTPUT);
  pinMode(sensorOut, INPUT);
  
  // Setting frequency-scaling to 20%
  digitalWrite(S0,HIGH);
  digitalWrite(S1,LOW);
  
  Serial.begin(9600);
}
void loop() {
  if(HCRS04Sensor() == true){
    String value_Return = TCS230Sensor();
    Serial.println(value_Return);
    started = false;
    delay(1000);
  }
}
String TCS230Sensor(){
  // Setting red filtered photodiodes to be read
  digitalWrite(S2,LOW);
  digitalWrite(S3,LOW);
  // Reading the output frequency
  fre_RE = pulseIn(sensorOut, LOW);
  fre_RE = map(fre_RE, 25,72,255,0);
  
  // Setting Green filtered photodiodes to be read
  digitalWrite(S2,HIGH);
  digitalWrite(S3,HIGH);
  // Reading the output frequency
  fre_GR = pulseIn(sensorOut, LOW);
  fre_GR = map(fre_GR, 25,72,255,0);
   
  // Setting Blue filtered photodiodes to be read
  digitalWrite(S2,LOW);
  digitalWrite(S3,HIGH);
  // Reading the output frequency
  fre_BL = pulseIn(sensorOut, LOW);
  fre_BL = map(fre_BL, 25,72,255,0);
   
  // Printing the value on the serial monitor
  //Serial.println((String)fre_RE + " " + (String)fre_GR + " " + (String)fre_BL);
  return (String)fre_RE + " " + (String)fre_GR + " " + (String)fre_BL;
}

bool HCRS04Sensor() {
  // Clears the trigPin
  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration = pulseIn(echoPin, HIGH);
  // Calculating the distance
  distance= duration*0.034/2;
  // Prints the distance on the Serial Monitor
  if(distance > 5)return false;
  
  started = true;
  return true;
}

