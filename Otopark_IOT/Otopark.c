
//kütüphaneler
#include <ESP8266WiFi.h>
#include "Servo.h"
#include "WiFiUdp.h"
#include "Adafruit_MQTT.h"
#include "Adafruit_MQTT_Client.h"

// 
const char *ssid =  "2.KAT";     // Enter your WiFi Name
const char *pass =  "ccNC54rQ"; // Enter your WiFi Password

#define MQTT_SERV "io.adafruit.com"
#define MQTT_PORT 1883
#define MQTT_NAME "rabiaabdioglu"
#define MQTT_PASS "aio_TvtQ03oBRJ8cWGjexnhWzFRp4mxJ"



WiFiClient client;
Adafruit_MQTT_Client mqtt(&client, MQTT_SERV, MQTT_PORT, MQTT_NAME, MQTT_PASS);

//Feedler

//buton 
Adafruit_MQTT_Subscribe KapiAc = Adafruit_MQTT_Subscribe(&mqtt, MQTT_NAME "/feeds/otopark.kapiac");
Adafruit_MQTT_Subscribe KapiKapa = Adafruit_MQTT_Subscribe(&mqtt, MQTT_NAME "/feeds/otopark.kapikapa");


//park yerleri 

Adafruit_MQTT_Publish ParkA1_Dolu = Adafruit_MQTT_Publish(&mqtt,MQTT_NAME "/feeds/otopark.parka1-dolu");
Adafruit_MQTT_Publish ParkA2_Dolu = Adafruit_MQTT_Publish(&mqtt,MQTT_NAME "/feeds/otopark.parka2-dolu");
Adafruit_MQTT_Publish BosYer = Adafruit_MQTT_Publish(&mqtt,MQTT_NAME "/feeds/otopark.bosyer");



//baslangic degerleri

int ir_cikis = 2; // D4  pini cikis sensoru
int ir_giris =0; // D3 pini giris sensoru
int araba_say=0;
int park1 = 5; // D1 pini cikis sensoru
int park2 =4; // D2 pini giris sensoru
String Dolu="DOLU";
String Bos="BOS";

Servo servo;

void setup()
{   Serial.begin(9600);
    mqtt.subscribe(&KapiAc);
    mqtt.subscribe(&KapiKapa);
    servo.attach(12); //servo motor D6 pininde
    servo.write(100); //servo motor 0 dan baslasin
    pinMode(ir_giris, INPUT); // giris sensoru 
    pinMode(ir_cikis, INPUT); // cikis sensoru


//wifi baglantisi 
  WiFi.begin(ssid, pass);                      
  Serial.print("Baglaniliyor....  :   ");
  Serial.print(ssid);                          
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");                         
    delay(500);
  }
  Serial.println();
  Serial.print("Baglandi. : ");
  Serial.println(ssid);
  Serial.print("IP Adresi : ");
  Serial.println(WiFi.localIP());              
   
}


void loop() {

  
MQTT_connect();     //Mqtt baglantisi yapilir.


Sensor_Kontrol();    //Sensor kontrolune gore engel acilip kapatilir.
AdaFruit_VeriYolla(); //Adafruit platformuna park yeri dolu-bos bilgisi yollanir
AdaFruit_Kontrol();   // AdaFruit platformundan buton kontrolu

BosYer.publish(ParkYeriSayisi());  // Her dongu sonunda Adafruite bos yer bilgisi yollanir

}


//gerekli fonksiyonlar
void Sensor_Kontrol(){
   if (digitalRead(ir_giris) == 0 )
   
   {
        if(ParkYeriSayisi()!=0)
        { 
          
          Serial.print("Giris yapildi ");
          servo.write(0);  }
          else{ Serial.println("Bos park yeri yok"); }
   } 
   
   else if (digitalRead(ir_cikis)==0)
   { // check if the input is HIGH
       Serial.print("Cikis yapildi");
       servo.write(0); 
   } 
   else 
   {  
    Serial.println("Kapi kapaniyor.."); 
     
      servo.write(100);    delay(500);
   } 
}
void AdaFruit_Kontrol(){
   //adafruit
   Adafruit_MQTT_Subscribe * subscription;


  while ((subscription = mqtt.readSubscription(5000)))
     {

               //Kapi ac butonu
              if (subscription == &KapiAc)
           {  Serial.println((char*) KapiAc.lastread);
           
                   if (!strcmp((char*) KapiAc.lastread, "1"))
                      {
                      servo.write(0);  
                       }
             }
             
                  //Kapi kapa butonu
               if (subscription == &KapiKapa)
           {  Serial.println((char*) KapiKapa.lastread);
           
                   if (!strcmp((char*) KapiKapa.lastread, "1"))
                      {
                      servo.write(100); 
                       }
             } }}

void AdaFruit_VeriYolla(){
  
/////////  Park Yerleri bos dolu verisi yolla

   if (digitalRead(park1)==0){

    ParkA1_Dolu.publish((char*)Dolu.c_str());  
    }
    else{ParkA1_Dolu.publish((char*)Bos.c_str());}

  if (digitalRead(park2)==0){

    ParkA2_Dolu.publish((char*)Dolu.c_str());
    
    }
    else{ParkA2_Dolu.publish((char*)Bos.c_str());}}


int ParkYeriSayisi()
{ 
  int bosyer=digitalRead(park1)+digitalRead(park2);
  
  return bosyer;
  }



//mqtt baglantisi

void MQTT_connect() 
{
  int8_t ret;

  // Stop if already connected.
  if (mqtt.connected()) 
  {
    return;
  }

  uint8_t retries = 3;
  while ((ret = mqtt.connect()) != 0) 
  { 
       mqtt.disconnect();
       delay(5000); 
       retries--;
       if (retries == 0) 
       {
         while (1);
       }
  }
}
 
