#include <PPMReader.h>
#include <Servo.h>


#define fren_1 A2
#define fren_2 A3
#define aktuator_1 A1
#define aktuator_2 A0
#define role_1 6
#define role_2 7
#define role_3 8
#define role_4 9
#define optik 4
#define enkoder 3
#define cpuLed 5
#define acildurum 13
#define levitasyonDur 10
#define levitasyonCalis 11

#define interruptPin 2
#define channelAmount 10

PPMReader ppm(interruptPin, channelAmount);

unsigned  kanal1, kanal2, kanal3, kanal4, kanal5, kanal6, kanal7, kanal8;
int counter_encoder = 0;
int counter_optik = 0;
int fren_mesafesi = 125;
bool haberlesme = false;
bool test = false;


void setup() {
  Serial.begin(115200);
  pin();
  attachInterrupt(digitalPinToInterrupt(enkoder), enkod, RISING);
}

void loop() {

  if (digitalRead(acildurum) == 0)
  {
    Serial.println("!Buton acili");
    acil();
  }

  kanal8 = ppm.latestValidChannelValue(8, 0);

  haberlesme = haberlesme_kontrol();
  
    if (counter_encoder > 532)
    {
      acil();
      digitalWrite(cpuLed, 1);
      Serial.println("!Enkoderden acile girdi");
      while(1);
    }
  

  if ( haberlesme)
  {
    kumanda();
  }
  else
  {
   
    emir();
    
  }
}
