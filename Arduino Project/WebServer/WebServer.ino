#include <SPI.h>
#include <Ethernet.h>

// khai bao ten cho cac chan dieu khien tren Arduino
int tb1 = 2;
int tb2 = 3;
int tb3 = 4;
int tb4 = 5;
int tb5 = 6;
int tb6 = 7;

// trang thai ban dau cua cac tran dieu khien
boolean tttb1, tttb2, tttb3, tttb4, tttb5, tttb6 = false;

String readString; 
char c;

// khai bao dia chi MAC va dia chi IP cho Arduino
// Enter a MAC address and IP address for your controller below.
// The IP address will be dependent on your local network:
byte mac[] = {
  0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED
};
IPAddress ip(192, 168, 1, 177);

// Initialize the Ethernet server library
// with the IP address and port you want to use
// (port 80 is default for HTTP):
EthernetServer server(80);

void setup() {
  // khai bao che do lam viec cua cac chan dieu khien la OUTPUT
  pinMode(tb1, OUTPUT);
  pinMode(tb2, OUTPUT);
  pinMode(tb3, OUTPUT);
  pinMode(tb4, OUTPUT);
  pinMode(tb5, OUTPUT);
  pinMode(tb6, OUTPUT);
  
  Serial.begin(9600);
  while (!Serial) { ; }
  Ethernet.begin(mac, ip);
  server.begin();
}

void loop() {
  EthernetClient client = server.available();
  if (client) {
    while (client.connected()) {   
      if (client.available()) {
        c = client.read(); 
        if (readString.length() < 100) {
          readString += c;
        }
        if (c == '\n') {
             client.println("HTTP/1.1 200 OK");
             client.println("Content-Type: text/html");
             client.println();     
             client.println("<HTML>");
             client.println("<HEAD>");
             client.println("<meta http-equiv=\"Refresh\" content=\"5; url=/tt\" />");
             client.println("<meta http-equiv=\"Content-Type\" content=\"application/vnd.wap.xhtml+xml; charset=utf-8\" />");
             client.println("<link type=\"text/css\" rel=\"stylesheet\" href=\"http://haidao.mw.lt/js_css/css_pages.css\" />");
             client.println("<TITLE>Điều khiển thiết bị qua Internet</TITLE>");
             client.println("</HEAD>");
             client.println("<BODY align=\"center\">");
             client.println("<h1>TRẠNG THÁI HIỆN TẠI CỦA THIẾT BỊ</h1>");
             client.println("<hr />"); 
             client.println("<br />"); 
             client.println("<br />"); 
             client.println("<table align=\"center\"><tr>");
             client.println("<th width=\"40%\">Tên thiết bị</th>");
             client.println("<th width=\"20%\">Trạng thái</th>");
             client.println("<th width=\"40%\">Hành động</th></tr>");
             client.println("<tr class=\"trh1\"><td align=\"left\">");
             client.println("&nbsp;");
             client.println("&nbsp;");
             client.println("Thiết bị 1");
             client.println("</td><td align=\"center\">");
             if (tttb1 == false) {
               client.println("<b>TẮT</b>");
             } else {
               client.println("<b>BẬT</b>");
             }
             client.println("</td><td align=\"center\">");
             if (tttb1 == false) {
               client.println("<a href=\"/1O\" />BẬT</a>");
             } else {
               client.println("<a href=\"/1F\" />TẮT</a>");
             }
             client.println("</td></tr>");
             client.println();
             client.println("<tr class=\"trh2\"><td align=\"left\">");
             client.println("&nbsp;");
             client.println("&nbsp;");
             client.println("Thiết bị 2");
             client.println("</td><td align=\"center\">");
             if (tttb2 == false) {
               client.println("<b>TẮT</b>");
             } else {
               client.println("<b>BẬT</b>");
             }
             client.println("</td><td align=\"center\">");
             if (tttb2 == false) {
               client.println("<a href=\"/2O\" />BẬT</a>");
             } else {
               client.println("<a href=\"/2F\" />TẮT</a>");
             }
             client.println("</td></tr>");
             client.println();
             client.println("<tr class=\"trh1\"><td align=\"left\">");
             client.println("&nbsp;");
             client.println("&nbsp;");
             client.println("Thiết bị 3");
             client.println("</td><td align=\"center\">");
             if (tttb3 == false) {
               client.println("<b>TẮT</b>");
             } else {
               client.println("<b>BẬT</b>");
             }
             client.println("</td><td align=\"center\">");
             if (tttb3 == false) {
               client.println("<a href=\"/3O\" />BẬT</a>");
             } else {
               client.println("<a href=\"/3F\" />TẮT</a>");
             }
             client.println("</td></tr>");
             client.println();
             client.println("<tr class=\"trh2\"><td align=\"left\">");
             client.println("&nbsp;");
             client.println("&nbsp;");
             client.println("Thiết bị 4");
             client.println("</td><td align=\"center\">");
             if (tttb4 == false) {
               client.println("<b>TẮT</b>");
             } else {
               client.println("<b>BẬT</b>");
             }
             client.println("</td><td align=\"center\">");
             if (tttb4 == false) {
               client.println("<a href=\"/4O\" />BẬT</a>");
             } else {
               client.println("<a href=\"/4F\" />TẮT</a>");
             }
             client.println("</td></tr>");
             client.println();
             client.println("<tr class=\"trh1\"><td align=\"left\">");
             client.println("&nbsp;");
             client.println("&nbsp;");
             client.println("Thiết bị 5");
             client.println("</td><td align=\"center\">");
             if (tttb5 == false) {
               client.println("<b>TẮT</b>");
             } else {
               client.println("<b>BẬT</b>");
             }
             client.println("</td><td align=\"center\">");
             if (tttb5 == false) {
               client.println("<a href=\"/5O\" />BẬT</a>");
             } else {
               client.println("<a href=\"/5F\" />TẮT</a>");
             }
             client.println("</td></tr>");
             client.println();
             client.println("<tr class=\"trh2\"><td align=\"left\">");
             client.println("&nbsp;");
             client.println("&nbsp;");
             client.println("Thiết bị 6");
             client.println("</td><td align=\"center\">");
             if (tttb6 == false) {
               client.println("<b>TẮT</b>");
             } else {
               client.println("<b>BẬT</b>");
             }
             client.println("</td><td align=\"center\">");
             if (tttb6 == false) {
               client.println("<a href=\"/6O\" />BẬT</a>");
             } else {
               client.println("<a href=\"/6F\" />TẮT</a>");
             }
             client.println("</td></tr></table>");
             client.println("<br />");
             client.println("<h6>Coppyright © 2016 Nguyễn Hoàng Chương | All right reserved.</h6>");  
             client.println("<br />"); 
             client.println("</BODY>");
             
             
           delay(1);
           client.stop();
           
           //dieu khien cac role
           if (readString.indexOf("1O") >0){ digitalWrite(tb1, HIGH); tttb1 = true; }
           if (readString.indexOf("1F") >0){ digitalWrite(tb1, LOW); tttb1 = false; }
           
           if (readString.indexOf("2O") >0){ digitalWrite(tb2, HIGH); tttb2 = true; }
           if (readString.indexOf("2F") >0){ digitalWrite(tb2, LOW); tttb2 = false; }
           
           if (readString.indexOf("3O") >0){ digitalWrite(tb3, HIGH); tttb3 = true; }
           if (readString.indexOf("3F") >0){ digitalWrite(tb3, LOW); tttb3 = false; }
           
           if (readString.indexOf("4O") >0){ digitalWrite(tb4, HIGH); tttb4 = true; }
           if (readString.indexOf("4F") >0){ digitalWrite(tb4, LOW); tttb4 = false; }
           
           if (readString.indexOf("5O") >0){ digitalWrite(tb5, HIGH); tttb5 = true; }
           if (readString.indexOf("5F") >0){ digitalWrite(tb5, LOW); tttb5 = false; }
           
           if (readString.indexOf("6O") >0){ digitalWrite(tb6, HIGH); tttb6 = true; }
           if (readString.indexOf("6F") >0){ digitalWrite(tb6, LOW); tttb6 = false; }
          
           readString="";
         }
       }
     }
   }
 }
