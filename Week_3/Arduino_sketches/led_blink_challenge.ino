const int LED1 = 4;  // Define pins for LEDs
const int LED2 = 5;
const int LED3 = 6;
const int LED4 = 7;

void setup() {
  pinMode(LED1, OUTPUT);  // Set the LEDs as outputs
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);
}

void loop() {
  // Turn LEDs on and off alternately
  digitalWrite(LED1, HIGH);
  digitalWrite(LED2, LOW);
  digitalWrite(LED3, HIGH);
  digitalWrite(LED4, LOW);
  delay(500);  // Wait

  digitalWrite(LED1, LOW);
  digitalWrite(LED2, HIGH);
  digitalWrite(LED3, LOW);
  digitalWrite(LED4, HIGH);
  delay(500);  // Wait
}
