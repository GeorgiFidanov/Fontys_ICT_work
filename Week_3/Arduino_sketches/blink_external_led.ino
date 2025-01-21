const int RED_LED = 4;  // Define the port for the red LED

void setup() {
  pinMode(RED_LED, OUTPUT);  // Set the red LED pin as output
}

void loop() {
  digitalWrite(RED_LED, HIGH);  // Turn the red LED on
  delay(1000);                  // Wait for a second
  digitalWrite(RED_LED, LOW);   // Turn the red LED off
  delay(1000);                  // Wait for a second
}
