void emir()
{
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


      else if (message == 5)
      {
        Serial.println("!lev acıldi");
        lev_ac();
      }

      else if (message == 6)
      {
        Serial.println("!lev kapandı");
        lev_kapa();
      }

      else if (message == 7)
      {
        Serial.println("!ikinci kademe");
        ikinci_kademe();

      }

      else if (message == 8)
      {
        Serial.println("!birinci kademe");
        ilk_kademe();
      }

      else if (message == 9)
      {
        Serial.println("!motor dur");
        motor_dur();
      }

      else if (message == 11)
      {
        Serial.println("!fren kapa");
        fren_kapa();
      }

      else if (message == 10)
      {
        Serial.println("!fren ac");
        fren_ac();
      }

      else if (message == 18)
      {
        Serial.println("!fren dur");
        fren_hareketsiz();
      }

      else if (message == 12)
      {
        Serial.println("!aktuator aç");
        aktuator_ac();
      }

      else if (message == 13)
      {
        Serial.println("!aktuator kapa");
        aktuator_kapa();
      }

      else if (message == 14)
      {
        Serial.println("!test başla");
        test = true;
      }
      else if (message == 15)
      {
        Serial.println("!test iptal");
        test = false;
      }
      else if (message == 16)
      {
        Serial.println("!motor ileri");
        motor_ileri();
      }
      else if (message == 17)
      {
        Serial.println("!motor geri");
        motor_geri();
      }

      else if (message == 3)
      {
        Serial.println("!uçuş");
        real_ucus();
      }
    }
  }
}


void real_ucus()
{
  if (test)
  {
    test_ucus();
  }

  else
  {

    int message;
    aktuator_ac();
    long zaman = millis();
    while (millis() - zaman < 4000)
    {

      if (Serial.available() != 0)
      {
        message = Serial.read();
        if (message == 1 || message == 2 || message == 4)
        {
          Serial.println("!Acile girdi");
          acil();
          return;
        }
      }

    }
    lev_ac();
    zaman = millis();
    while (millis() - zaman < 12000)
    {
      if (Serial.available() != 0)
      {
        message = Serial.read();
        if (message == 1 || message == 2 || message == 4)
        {
          Serial.println("!Acile girdi");
          acil();
          return;
        }
      }

    }
    aktuator_kapa();
    zaman = millis();
    while (millis() - zaman < 3000)
    {
      if (Serial.available() != 0)
      {
        message = Serial.read();
        if (message == 1 || message == 2 || message == 4)
        {
          Serial.println("!Acile girdi");
          acil();
          return;
        }
      }

    }

    real_ucus(125);
  }
}
