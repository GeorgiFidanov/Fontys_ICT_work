const int RED_LED = 4;  // Pin for red LED

void setup() {
  pinMode(RED_LED, OUTPUT);  // Set red LED as output
}

void loop() {
  digitalWrite(RED_LED, HIGH);  // Turn the red LED on
  delay(500);                   // Wait for half a second
  digitalWrite(RED_LED, LOW);   // Turn the red LED off
  delay(500);                   // Wait for half a second
}