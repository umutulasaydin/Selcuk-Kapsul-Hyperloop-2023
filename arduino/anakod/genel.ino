void pin()
{
  pinMode(fren_1, OUTPUT);
  pinMode(fren_2, OUTPUT);
  pinMode(aktuator_1, OUTPUT);
  pinMode(aktuator_2, OUTPUT);


  pinMode(role_1, OUTPUT);
  pinMode(role_2, OUTPUT);
  pinMode(role_3, OUTPUT);
  pinMode(role_4, OUTPUT);

  pinMode(levitasyonCalis, OUTPUT);
  pinMode(levitasyonDur, OUTPUT);

  pinMode(cpuLed, OUTPUT);
  pinMode(optik, INPUT);
  pinMode(enkoder, INPUT);
  pinMode(acildurum, INPUT);


  digitalWrite(levitasyonCalis, 1);
  digitalWrite(levitasyonDur, 0);
  digitalWrite(role_1, 1);
  digitalWrite(role_2, 1);
  digitalWrite(role_3, 1);
  digitalWrite(role_4, 1);
  digitalWrite(fren_1, 1);
  digitalWrite(fren_2, 1);
  digitalWrite(aktuator_1, 1);
  digitalWrite(aktuator_2, 1);

  pinMode(12, INPUT);
  pinMode(A6, INPUT);
  pinMode(A7, INPUT);

}


void fren_ac()
{
  digitalWrite(fren_1, 0);
  digitalWrite(fren_2, 1);
}

void fren_kapa()
{
  
  digitalWrite(fren_1, 0);
  digitalWrite(fren_2, 0);
}

void fren_hareketsiz()
{
  
  digitalWrite(fren_1, 1);
  digitalWrite(fren_2, 1);
}

void aktuator_ac()
{
  digitalWrite(aktuator_1, 1);
  digitalWrite(aktuator_2, 0);
}

void aktuator_kapa()
{
  digitalWrite(aktuator_1, 0);
  digitalWrite(aktuator_2, 0);
}

void lev_ac()
{
  digitalWrite(levitasyonDur, 1);
  digitalWrite(levitasyonCalis, 0);
}

void lev_kapa()
{
  digitalWrite(levitasyonCalis, 1);
}

/*void lev_sert_dur_ac()
{
  digitalWrite(levitasyonCalis, 1);
  digitalWrite(levitasyonDur, 0);
}

void lev_sert_dur_kapa()
{
  digitalWrite(levitasyonDur, 1);
}*/

void motor_kapa()
{
  digitalWrite(role_1, 1);
  digitalWrite(role_2, 1);
  digitalWrite(role_3, 1);
  digitalWrite(role_4, 1);
}

void motor_geri()
{
  digitalWrite(role_1, 0);
  digitalWrite(role_2, 0);
}

void motor_ileri()
{
  digitalWrite(role_1, 0);
  digitalWrite(role_2, 1);
}

void motor_dur()
{

  digitalWrite(role_3, 1);
  digitalWrite(role_4, 1);
}

void ilk_kademe()
{
  digitalWrite(role_3, 0);
  digitalWrite(role_4, 1);
}

void ikinci_kademe()
{
  digitalWrite(role_3, 0);
  digitalWrite(role_4, 0);
}

void acil()
{
  digitalWrite(fren_1, 0);
  digitalWrite(fren_2, 0);
  digitalWrite(levitasyonDur, 0);
  digitalWrite(role_1, 1);
  digitalWrite(role_2, 1);
  digitalWrite(role_3, 1);
  digitalWrite(role_4, 1);
  delay(10000);
  digitalWrite(fren_1, 0);
  digitalWrite(fren_2, 1);
  delay(2000);
  digitalWrite(levitasyonCalis, 1);
}
