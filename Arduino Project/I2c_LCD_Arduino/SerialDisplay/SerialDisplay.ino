#include <ESP8266WiFi.h>
 
const char* ssid = "Minh Hoa";// tên wifi mà bạn muốn connect
const char* password = "19562010";//pass wifi
 
int ledPin = 2; // GPIO2
WiFiServer server(80);// Port 80
 
void setup() {
  Serial.begin(115200);
  delay(10);
   
  pinMode(ledPin, OUTPUT);
  digitalWrite(ledPin, LOW);
   
  // Kết nỗi với wifi
  Serial.println();
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(ssid);
   
  WiFi.begin(ssid, password);
   
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("WiFi connected");
   
  // Bắt đầu sever
  server.begin();
  Serial.println("Server started");
   
  // In địa chỉ IP 
  Serial.print("Use this URL to connect: ");
  Serial.print("http://");
  Serial.print(WiFi.localIP());
  Serial.println("/");
}
 
void loop() {
  // Kiểm tra xem đã connect chưa
  WiFiClient client = server.available();
  if (!client) {
    return;
  }
   
  // Đọc data
  Serial.println("new client");
  while(!client.available()){
    delay(1);
  }
   
  String request = client.readStringUntil('\r');
  Serial.println(request);
  int tmp = client.read();
  //Serial.write(tmp);
  Serial.println(tmp);
  if(tmp == 49){
     digitalWrite(ledPin, HIGH);
  }
  else if(tmp == 48){
    digitalWrite(ledPin, LOW);
  }
  
  client.flush();
   
  int value = LOW;
  if (request.indexOf("/LED=ON") != -1) {
    digitalWrite(ledPin, HIGH);
    value = HIGH;
  }
  if (request.indexOf("/LED=OFF") != -1) {
    digitalWrite(ledPin, LOW);
    value = LOW;
  }
  //digitalWrite(ledPin, value);
 
 
  // Tạo giao diện cho html!!! giống con elthernet shield á!!! bạn có thể thiết kế 1 giao diện html khác, cho đẹp
  client.println("HTTP/1.1 200 OK");
  client.println("Content-Type: text/html");
  client.println(""); // do not forget this one
  client.println("<!DOCTYPE HTML>");
  client.println("<html>");
   
  client.print("Led pin is now: ");
   
  if(value == HIGH) {
    client.print("On");
  } 
  else {
    client.print("Off");
  }
  client.println("<br><br>");
  client.println("Click <a href=\"/LED=ON\">here</a> turn the LED on pin 2 ON<br>");
  client.println("Click <a href=\"/LED=OFF\">here</a> turn the LED on pin 2 OFF<br>");
  client.println("</html>");
   
  delay(1);
  Serial.println("Client disonnected");
  Serial.println("");
 
}

