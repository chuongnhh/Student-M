//////////INCLUDE HEADER FILES //////////////////
#include <Ethernet.h>
#include <SPI.h>
#include <EEPROM.h>
#include <LiquidCrystal.h>
#include <SD.h>
#include <Wire.h>


EthernetServer server(80);
String content;
File myFile;
int ledPin = 13;
int  outputpin = 0;
void setup()
{
  IPAddress ip( 192, 168,1,177);
  byte mac[] = { 
    0xDE,0xAE,0xBE,0xEF,0xFE,0xED
  };

  Ethernet.begin( mac, ip );
  server.begin();
  if ( ! SD.begin( 4 ) ) 
  {
    return;
  }
  pinMode(ledPin,OUTPUT);
  Serial.begin(9600);
}
///////////////////////////////////////////////


void loop()
{
  waitIncommingConnection();                                                             
}



void waitIncommingConnection()
{

  String pwd = "";
  String inData = "";
  EthernetClient client = server.available();
  
  if ( client  )
  {
    while ( client.connected() ) 
    {      
      if ( client.available() > 0)
      { 
        char recieved = client.read();
        inData += recieved;                       
        if (recieved == '\n')
        {                           
          switch( inData[0] )
          {                            
            case (char)'o' : 
              client.println("o");
              digitalWrite(ledPin, HIGH);
            break;

            case (char)'f' :
              client.println("f");
              digitalWrite(ledPin, LOW);
            break;
  
             case (char)'c' :
                 client.println(getTemperature());
            break;
            
            case (char)'*' :
              Logout(client);  
            break;
          
            default:
               client.println('d');
            break;
          }
          inData = ""; 
        }

      }
    }
  }
  else
  {
   client.println('v');
  }
}

float getTemperature()
{
  int rawvoltage= analogRead(outputpin);
  float millivolts= (rawvoltage/1024.0) * 4800;
  float kelvin= (millivolts/10);
  
  
  float celsius= kelvin - 273.15;

  return celsius;


}

void Logout(EthernetClient client )
{ 
  client.print('x');
  client.stop(); 

}



