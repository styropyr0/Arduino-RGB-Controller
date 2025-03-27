/*
Please don't modify the source code or at the least the setup function
Developer: Saurav Sajeev
Mail: sauravsajeev202@gmail.com
*/
#include<LiquidCrystal.h>

long int val;
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
int r=0, g=0, b=0;
int dval=0;
int red=6, green=9, blue=10, r1=1, g1=0, b1=1, fred=255, fblue=150, fgreen=0;
void setup() {
lcd.begin(16, 2);
lcd.setCursor(0, 0);
lcd.write("Waiting for");
lcd.setCursor(0, 1);
lcd.write("handshake...");

Serial.begin(9600);
Serial.println("Waiting for handshake signal with computer...");
int handshake=0;
while(handshake!=9090){
  Serial.println("FTERjhgdstkjlsa");
  handshake=Serial.parseInt();
}
Serial.println("Handshake recieved");
delay(1000);
lcd.clear();
lcd.setCursor(0, 0);
lcd.write("Handshake");
lcd.setCursor(0, 1);
lcd.write("recieved");
Serial.println("COMMANDLINE CONTROL\nENTER A VALUE 0~768");
lcd.clear();
lcd.setCursor(0, 0);
lcd.write("RANGE:0~768");
for(int i=6; i<11; i++)
pinMode(i, OUTPUT);
Serial.setTimeout(1000);
}

void loop() {
while(Serial.available()==0){}
val=Serial.parseInt();
Serial.println(val);
if(val<256&&val>0){
  r=val;
  analogWrite(red, r);
  Serial.println("RED");
  lcd.setCursor(0, 1);
lcd.write("                     ");
lcd.setCursor(0, 1);
lcd.print("RED #");
lcd.print(r);
}
else if(val>255&&val<512){
  g=val;
  analogWrite(green, g-256);
  Serial.println("GREEN");
  lcd.setCursor(0, 1);
lcd.write("                     ");
lcd.setCursor(0, 1);
lcd.print("GREEN #");
lcd.print(g-256);
}
else if(val>511&&val<768){
  b=val;
  analogWrite(blue, b-512);
  Serial.println("BLUE");
  lcd.setCursor(0, 1);
lcd.write("                     ");
lcd.setCursor(0, 1);
lcd.print("BLUE #");
lcd.print(b-512);
}
else if(val==1024){
  for(int i=6; i<11; i++)
  digitalWrite(i, LOW);

lcd.setCursor(0, 1);
lcd.write("                     ");
lcd.setCursor(0, 1);
lcd.write("OFF");
}
else if(val>1024){
  lcd.setCursor(0,0);
lcd.write("DYNAMIC LIGHTING");
  dval=val/110;
  if(Serial.available()>0){
    r=Serial.parseInt();
  }
  while(Serial.available()==0){
    
    if ((r1==1)&&(fred>0))
 {
 r1 = 1;
 fred -= 5;
 //Serial.print("dec red");
 //Serial.println(fred);
}
else{
  if(fred==255)
  r1=1;
  else if(r1==0)
  fred+=5;
  else if(fred==0)
  r1=0;
}

if ((g1==1)&&(fgreen>0))
 {
 g1 = 1;
 fgreen -= 5;
 //Serial.print("dec green");
 //Serial.println(fgreen);
}
else{
  if(fgreen==255)
  g1=1;
  else if(g1==0)
  fgreen+=5;
  else if(fgreen==0)
  g1=0;
}

if ((b1==1)&&(fblue>0))
 {
 b1 = 1;
 fblue -= 5;
 //Serial.print("dec blue");
 //Serial.println(fblue);
}
else{
  if(fblue==255)
  b1=1;
  else if(b1==0)
  fblue+=5;
  else if(fblue==0)
  b1=0;
}

 analogWrite(red,fred);
 analogWrite(green, fgreen);
 analogWrite(blue, fblue);
 delay(dval);

lcd.setCursor(0, 1);
lcd.print("[");
lcd.print(fred);
lcd.print("][");
lcd.print(fgreen);
lcd.print("][");
lcd.print(fblue); 
lcd.print("]      ");
    
    }
  val=Serial.parseInt();
  for(int i=6; i<11; i++){
    digitalWrite(i, LOW);
  }    
lcd.setCursor(0,0);
lcd.print("                  ");
lcd.setCursor(0,0);
lcd.print("RANGE:0~768");
lcd.setCursor(0, 1);
lcd.print("                     ");
lcd.setCursor(0, 1);
lcd.print("OFF");
}
else if(val!=0&&val!=1024)
Serial.println("NO EFFECT");

}
