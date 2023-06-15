double enkod_time = millis();

void enkod()
{
  long new_time = millis();
  if (new_time - enkod_time > 20)
  {
    noInterrupts();
    ++counter_encoder;
    enkod_time = new_time;
    Serial.println("!Enkoder: " + String(counter_encoder * 23.5 / 100));
    interrupts();
  }
}

void real_ucus(int fren_mesafesi)
{

  double konumlar [] = {0, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 66, 70, 74, 78, 82, 86, 86.1, 86.2, 86.3, 86.4, 86.5, 86.6, 86.7, 86.8, 86.9, 87, 87.1, 87.2, 87.3, 87.4, 87.5, 87.6, 87.7, 87.8, 87.9, 90, 94, 98, 102, 106, 110, 114, 118, 122, 126, 130, 134, 138, 138.1, 138.2, 138.3, 138.4, 138.5, 138.6, 138.7, 138.8, 138.9, 142, 146, 150, 154, 158, 162, 166, 170, 174, 178, 182, 186};
  double hizlar [sizeof(konumlar) / sizeof(double)] = {0};
  int detected_Ref = 0;
  int count = 0;
  int control = 0;
  double old_detection_time = millis();
  double new_detection_time = millis();
  double time_;
  double time_difference;
  double prev_old_time;
  double prev_new_time;
  double min_time = 0.1 / 30;
  bool fren = false;
  double fren_time = 0;
  motor_geri();
  ikinci_kademe();
  Serial.println("!Motor açıldı");
  while (konumlar[counter_optik] < konumlar[(sizeof(konumlar) / sizeof(double)) - 1] && counter_encoder * 23.5 / 100 < konumlar[(sizeof(konumlar) / sizeof(double)) - 1])
  {

    if (fren == false && (konumlar[counter_optik] > fren_mesafesi - 5 || counter_encoder * 23.5 / 100 > fren_mesafesi))
    {
      Serial.println("!Uçuşta fren yapıldı");
      fren = true;
      lev_kapa();
      motor_kapa();
      fren_kapa();
      fren_time = millis();
    }
    if (fren == true && millis() - fren_time > 5000)
    {
      Serial.println("!Kontrol bizde");
      return;
    }

    if (Serial.available() != 0)
    {
      int message = Serial.read();
      if (message != 0)
      {
        if (message == 1 || message == 2  || message == 4)
        {
          Serial.println("!acil basıldı");
          acil();
        }
      }
    }

    time_ = millis();
    if (digitalRead(optik) == LOW)
    {

      if (control == 0) {
        prev_old_time = old_detection_time;
        prev_new_time = new_detection_time;
        old_detection_time = new_detection_time;
        new_detection_time = time_ / 1000;
        time_difference = new_detection_time - old_detection_time;

        if (time_difference > min_time) {

          counter_optik = counter_optik + 1;
          control = 1;
          hizlar[counter_optik] = (konumlar[counter_optik] - konumlar[counter_optik - 1]) / time_difference;
          double a = (hizlar[counter_optik] - hizlar[counter_optik - 1]) / time_difference;

          Serial.println(String(time_difference) + "/" + String(konumlar[counter_optik]) + "/" + String(hizlar[counter_optik]) + "/" + String(a) + "/0/0/0/0/0/0/0/0/0/0/0/0");
        }
        else {
          old_detection_time = prev_old_time;
          new_detection_time = prev_old_time;
          control = 1;
        }
      }
      detected_Ref = 1;
    }
    else
    {
      control = 0;
      detected_Ref = 0;
    }
  }

}

void test_ucus()
{
  Serial.println("!Teste girdi");
  int detected_Ref = 0;
  int count = 0;
  int control = 0;
  double old_detection_time = 0;
  double new_detection_time = 0;
  double time_;
  double time_difference;
  double prev_old_time;
  double prev_new_time;
  double min_time = 0.1 / 30;
  counter_optik = 0;
  double konumlar [] = {0, 1, 2, 3, 4, 4.1, 4.2};
  double hizlar [sizeof(konumlar) / sizeof(double)] = {0};

  while (counter_optik + 1 != sizeof(konumlar) / sizeof(double))
  {
    time_ = millis();
    if (digitalRead(optik) == LOW)
    {

      if (control == 0) {
        prev_old_time = old_detection_time;
        prev_new_time = new_detection_time;
        old_detection_time = new_detection_time;
        new_detection_time = time_ / 1000;
        time_difference = new_detection_time - old_detection_time;

        if (time_difference > min_time) {

          counter_optik = counter_optik + 1;
          control = 1;
          hizlar[counter_optik] = (konumlar[counter_optik] - konumlar[counter_optik - 1]) / time_difference;
          double a = (hizlar[counter_optik] - hizlar[counter_optik - 1]) / time_difference;

          Serial.println(String(time_difference) + "/" + String(konumlar[counter_optik]) + "/" + String(hizlar[counter_optik]) + "/" + String(a) + "/0/0/0/0/0/0/0/0/0/0/0/0");
        }
        else {
          old_detection_time = prev_old_time;
          new_detection_time = prev_old_time;
          control = 1;
        }
      }
      detected_Ref = 1;
    }
    else
    {
      control = 0;
      detected_Ref = 0;
    }
  }
}
