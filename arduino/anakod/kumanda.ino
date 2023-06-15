void ucus()
{
  if (kanal4 <= 1200)
  {
    delay(10);
    if (ppm.latestValidChannelValue(4, 0) <= 1200)
    {
      aktuator_ac();
      long zaman = millis();
      while (millis() - zaman < 4000)
      {
        kanal2 = ppm.latestValidChannelValue(2, 0);
        if (kanal2 <= 1100 || digitalRead(acildurum) == 0)
        {
          return;
        }
      }
      lev_ac();
      zaman = millis();
      while (millis() - zaman < 12000)
      {
        kanal2 = ppm.latestValidChannelValue(2, 0);
        if (kanal2 <= 1100 || digitalRead(acildurum) == 0)
        {
          return;
        }
      }
      aktuator_kapa();
      zaman = millis();
      while (millis() - zaman < 2000)
      {
        kanal2 = ppm.latestValidChannelValue(2, 0);
        if (kanal2 <= 1100 || digitalRead(acildurum) == 0)
        {
          return;
        }
      }

      counter_encoder = 0;
      motor_ileri();
      ilk_kademe();
      while (counter_encoder < 45)
      {
        if (ppm.latestValidChannelValue(2, 0) <= 1100)
        {
          delay(100);
          if (ppm.latestValidChannelValue(2, 0) <= 1100)
          {
            return;
          }
        }
        if (digitalRead(acildurum) == 0)
        {
          return;
        }
      }
      lev_kapa();
      motor_kapa();
      fren_kapa();
      zaman = millis();
      while (millis() - zaman < 10000)
      {
        kanal2 = ppm.latestValidChannelValue(2, 0);
        if (kanal2 <= 1100 || digitalRead(acildurum) == 0)
        {
          return;
        }
      }
      fren_ac();
      
    }
  }
}

void acil_kontrol()
{
  if (kanal2 <= 1100)
  {
    delay(10);
    if (ppm.latestValidChannelValue(2, 0) <= 1100)
    {
      acil();
    }
  }

  if (digitalRead(acildurum) == 0)
  {
    acil();
  }
}

bool haberlesme_kontrol()
{
  if ( kanal8 == 2000)
  {
    delay(10);
    if (ppm.latestValidChannelValue(8, 0) == 2000)
    {
      //detachInterrupt(digitalPinToInterrupt(interruptPin));
      return true;
    }
  }

  else if (kanal8 == 1000)
  {
    delay(10);
    if (ppm.latestValidChannelValue(8, 0) == 1000)
    {
      return false;
    }
  }
  return false;
}

void aktuator_kontrol()
{
  if (kanal6 >= 1800)
  {
    delay(10);
    if (ppm.latestValidChannelValue(6, 0) >= 1800)
    {
      aktuator_ac();
    }
  }
  else if (kanal6 <= 1200)
  {
    delay(10);
    if (ppm.latestValidChannelValue(6, 0) <= 1200)
    {
      aktuator_kapa();
    }

  }
}

void lev_kontrol()
{
  if (kanal5 >= 1500)
  {
    delay(10);
    if (ppm.latestValidChannelValue(5, 0) >= 1500)
    {

      lev_ac();
    }



  }
  else
  {
    delay(10);
    if (ppm.latestValidChannelValue(5, 0) < 1500)
    {

      lev_kapa();
    }

  }
}


void motor_kontrol()
{
  if (kanal7 >= 1400 && kanal7 <= 1600)
  {
    delay(10);
    if ( ppm.latestValidChannelValue(7, 0) >= 1400 && ppm.latestValidChannelValue(7, 0) <= 1600)
    {
      motor_kapa();
    }

  }
  else if ( kanal7 <= 1200)
  {
    delay(10);
    if ( ppm.latestValidChannelValue(7, 0) <= 1200)
    {
      motor_geri();
      if (kanal3 <= 1200)
      {
        delay(10);
        if (ppm.latestValidChannelValue(3, 0) <= 1200)
        {
          motor_dur();
        }
      }

      else if (kanal3 <= 1600)
      {
        delay(10);
        if (ppm.latestValidChannelValue(3, 0) <= 1600)
        {
          ilk_kademe();
        }
      }

      else if (kanal3 >= 1800)
      {
        delay(10);
        if (ppm.latestValidChannelValue(3, 0) >= 1800)
        {
          ikinci_kademe();
        }
      }
    }
  }

  else if (kanal7  >= 1800)
  {
    delay(10);
    if ( ppm.latestValidChannelValue(7, 0) >= 1800)
    {
      motor_ileri();
      if (kanal3 <= 1200)
      {
        delay(10);
        if (ppm.latestValidChannelValue(3, 0) <= 1200)
        {
          motor_dur();
        }
      }

      else if (kanal3 <= 1600)
      {
        delay(10);
        if (ppm.latestValidChannelValue(3, 0) <= 1600)
        {
          ilk_kademe();
        }
      }

      else if (kanal3 >= 1800)
      {
        delay(10);
        if (ppm.latestValidChannelValue(3, 0) >= 1800)
        {
          ikinci_kademe();
        }
      }
    }
  }


}

void fren_kontrol()
{
  if (kanal1 <= 1200)
  {
    delay(10);
    if (ppm.latestValidChannelValue(1, 0) <= 1200)
    {
      fren_ac();
    }
  }

  else if (kanal1 >= 1800)
  {
    delay(10);
    if (ppm.latestValidChannelValue(1, 0) >= 1800)
    {
      fren_kapa();
    }
  }

  else if (kanal1 >= 1400 && kanal1 <= 1600)
  {
    delay(10);
    if (ppm.latestValidChannelValue(1, 0) >= 1400 && ppm.latestValidChannelValue(1, 0) <= 1600)
    {
      fren_hareketsiz();
    }
  }
}

void kumanda()
{
  kanal1 = ppm.latestValidChannelValue(1, 0);
  kanal2 = ppm.latestValidChannelValue(2, 0);
  kanal3 = ppm.latestValidChannelValue(3, 0);
  kanal4 = ppm.latestValidChannelValue(4, 0);
  kanal5 = ppm.latestValidChannelValue(5, 0);
  kanal6 = ppm.latestValidChannelValue(6, 0);
  kanal7 = ppm.latestValidChannelValue(7, 0);


  fren_kontrol();
  motor_kontrol();
  ucus();
  acil_kontrol();
  aktuator_kontrol();
  lev_kontrol();
}
