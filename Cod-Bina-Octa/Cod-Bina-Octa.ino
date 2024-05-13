#include <Wire.h> 
#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(0x27,16,2);
String binario;
String Octal;
void setup() {
  Serial.begin(9600);
lcd.init();
  lcd.backlight();
}

void loop() {
   if (Serial.available() > 0) { // Si hay datos disponibles en el puerto serie
    binario = Serial.readString();
  Octal = Serial.readString(); // Lee la cadena de datos binarios
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Binario y OCTAL: ");
    lcd.setCursor(0,1);
    lcd.print(binario);
     lcd.print(Octal);
  }
}
