/*
  Web Server

 A simple web server that shows the value of the analog input pins.
 using an Arduino Wiznet Ethernet shield.

 Circuit:
 * Ethernet shield attached to pins 10, 11, 12, 13
 * Analog inputs attached to pins A0 through A5 (optional)

 created 18 Dec 2009
 by David A. Mellis
 modified 9 Apr 2012
 by Tom Igoe
 modified 02 Sept 2015
 by Arturo Guadalupi

 */

#include <SPI.h>
#include <Ethernet.h>

int pin5 = 5;
int pin6 = 6;
String readString;
// Enter a MAC address and IP address for your controller below.
// The IP address will be dependent on your local network:
byte mac[] = {
  0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED
};
IPAddress ip(192, 168, 1, 178);

// Initialize the Ethernet server library
// with the IP address and port you want to use
// (port 80 is default for HTTP):
EthernetServer server(80);

void setup() {
  // Open serial communications and wait for port to open:
  Serial.begin(9600);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
  pinMode(pin5, OUTPUT);digitalWrite(pin5, LOW);
  pinMode(pin6, OUTPUT);digitalWrite(pin6, LOW);
  //pinMode(pin7, OUTPUT);digitalWrite(pin7, LOW);
  //pinMode(pin8, OUTPUT);digitalWrite(pin8, LOW);

  // start the Ethernet connection and the server:
  Ethernet.begin(mac, ip);
  server.begin();
  Serial.print("server is at ");
  Serial.println(Ethernet.localIP());
}


void loop() {
  // listen for incoming clients
  EthernetClient client = server.available();
  if (client) {
    Serial.println("new client");
    // an http request ends with a blank line
    while (client.connected()) {
      if (client.available()) {
        char c = client.read();
        //Serial.write(c);

        //read char by char HTTP request
        if (readString.length() < 100) {
          //store characters to string
          readString += c;
          //Serial.print(c);
         }
         
        // if you've gotten to the end of the line (received a newline
        // character) and the line is blank, the http request has ended,
        // so you can send a reply
        if (c == '\n') {
          Serial.println(readString); //print to serial monitor for debuging
          // send a standard http response header
          client.println("HTTP/1.1 200 OK");
          client.println("Content-Type: text/html");
          //client.println("Connection: close");  // the connection will be closed after completion of the response
          //client.println("Refresh: 5");  // refresh the page automatically every 5 sec
          client.println();
          client.println("<!DOCTYPE HTML>");
          client.println("<html>");

          client.println("<HEAD>");
          client.println("<meta name='apple-mobile-web-app-capable' content='yes' />");
          client.println("<meta name='apple-mobile-web-app-status-bar-style' content='black-translucent' />");
          client.println("<link rel='stylesheet' type='text/css' href='http://randomnerdtutorials.com/ethernetcss.css' />");
          client.println("<TITLE>IoT LED Control</TITLE>");
          client.println("</HEAD>");

          client.println("<BODY>"); 
          client.println("<H1>Nguyen Hoang Chuong!</H1>");
           client.println("<hr />");
          client.println("<H1>Welcome IoT</H1>");
          client.println("<br />");  
          client.println("<a href=\"/?button1on\"\">Turn On Pin 5</a>");
          client.println("<a href=\"/?button1off\"\">Turn Off Pin 5</a><br />");   
          client.println("<br />");     
          
          client.println("<a href=\"/?button2on\"\">Turn On Pin 6</a>");
          client.println("<a href=\"/?button2off\"\">Turn Off Pin 6</a><br />"); 
          client.println("<br />");
          client.println("</BODY>");        
          client.println("</html>");
          break;
        }
      }
    }
    // give the web browser time to receive the data
    delay(1);
    // close the connection:
    client.stop();
    if (readString.indexOf("?button1on") >0){
           digitalWrite(pin5, HIGH);
       }
    if (readString.indexOf("?button1off") >0){
           digitalWrite(pin5, LOW);
       }

    if (readString.indexOf("?button2on") >0){
           digitalWrite(pin6, HIGH);
       }
    if (readString.indexOf("?button2off") >0){
           digitalWrite(pin6, LOW);
       }
    readString="";  
  }
}

