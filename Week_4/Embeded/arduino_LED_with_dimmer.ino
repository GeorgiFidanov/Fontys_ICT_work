const int POTPIN = A0;
const int LEDPIN = 4;  // this is for red, but for best effect test with blue(6)

void setup() {
  pinMode(POTPIN, INPUT);
  pinMode(LEDPIN, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  int val = analogRead(POTPIN);
  int brightness = map(val, 0, 1023, 0, 255);
  
  analogWrite(LEDPIN, brightness);        // Set the LED brightness
  Serial.print("Potentiometer Value: ");
  Serial.print(val);
  Serial.print(" -> LED Brightness: ");
  Serial.println(brightness);
  
  delay(100);
}
