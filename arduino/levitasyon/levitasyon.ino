// Levitasyon Arduino
#include <Servo.h>

#define PWM_6 3
#define PWM_5 5
#define PWM_4 6
#define PWM_3 9
#define PWM_2 10
#define PWM_1 11

#define basla A0
#define dur A1

Servo ESC_1, ESC_2, ESC_3, ESC_4, ESC_5, ESC_6;

const int16_t rampa = 10000; // Rampa süresi (ms)
int deger = 180;             // Motor kaça kadar çıkacak (tepe değer 180)
unsigned long zaman = 0;
bool i = 0; // Zaten çalışıyorsa birdaha girmemesi için

void setup() 
{
  Serial.begin(115200);
  pinMode(basla, INPUT);
  pinMode(dur, INPUT);
  
  pinMode(PWM_6, OUTPUT);
  pinMode(PWM_5, OUTPUT);
  pinMode(PWM_4, OUTPUT);
  pinMode(PWM_3, OUTPUT);
  pinMode(PWM_2, OUTPUT);
  pinMode(PWM_1, OUTPUT);
  delay(100);
  
  ESC_1.attach(PWM_1);delay(10);
  ESC_2.attach(PWM_2);delay(10);
  ESC_3.attach(PWM_3);delay(10);
  ESC_4.attach(PWM_4);delay(10);
  ESC_5.attach(PWM_5);delay(10);
  ESC_6.attach(PWM_6);delay(10);

  ESC_1.write(0);delay(10);
  ESC_2.write(0);delay(10);
  ESC_3.write(0);delay(10);
  ESC_4.write(0);delay(10);
  ESC_5.write(0);delay(10);
  ESC_6.write(0);delay(10);

}
    
void loop() 
{
    bool b = digitalRead(basla); //0    A0
    bool d = digitalRead(dur);  //1    A1
    Serial.print(b);Serial.print("\t");
    Serial.print(d);Serial.print("\n");
  
  if(d == 0) // Ayni Dur
  {
  ESC_1.write(0);delay(10);
  ESC_2.write(0);delay(10);
  ESC_3.write(0);delay(10);
  ESC_4.write(0);delay(10);
  ESC_5.write(0);delay(10);
  ESC_6.write(0);delay(10);
  b = 1;
  i = 0;
  }
  if((b == 0) && (i == 0)) // Rampalı Kalkış
  {
    int a = 0;
    while(a <= deger)
    {
      if (millis() - zaman > (rampa/deger))
      {
        a++;
        ESC_1.write(a);delay(1);
        ESC_2.write(a);delay(1);
        ESC_3.write(a);delay(1);
        ESC_4.write(a);delay(1);
        ESC_5.write(a);delay(1);
        ESC_6.write(a);delay(1);
        if(digitalRead(dur) == 0)
        {
            ESC_1.write(0);delay(10);
            ESC_2.write(0);delay(10);
            ESC_3.write(0);delay(10);
            ESC_4.write(0);delay(10);
            ESC_5.write(0);delay(10);
            ESC_6.write(0);delay(10);
            b = 1;
            i = 0;
            break;
          }
        zaman = millis();
      }
    }
    i = 1;
  }
  else if((b == 1) && (i == 1)) // Rampalı duruş
  {
    int a = deger;
    while(a >= 0)
    {
      if (millis() - zaman > ((rampa/2)/deger))
      {
        a--;
        ESC_1.write(a);delay(1);
        ESC_2.write(a);delay(1);
        ESC_3.write(a);delay(1);
        ESC_4.write(a);delay(1);
        ESC_5.write(a);delay(1);
        ESC_6.write(a);delay(1);
        if(digitalRead(dur) == 0)
        {
          ESC_1.write(0);delay(10);
          ESC_2.write(0);delay(10);
          ESC_3.write(0);delay(10);
          ESC_4.write(0);delay(10);
          ESC_5.write(0);delay(10);
          ESC_6.write(0);delay(10);
          b = 1;
          i = 0;
          break;
        }
        zaman = millis();
      }
    }
    i = 0;
  }
}
