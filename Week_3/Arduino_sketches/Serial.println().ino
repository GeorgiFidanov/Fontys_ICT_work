const int RED_LED = 4;

void setup() {
  pinMode(RED_LED, OUTPUT);  // Set red LED as output
  Serial.begin(9600);        // Initialize serial communication
}

void loop() {
  digitalWrite(RED_LED, HIGH);  // Turn the red LED on
  Serial.println("LED on");     // Print message
  delay(1000);

  digitalWrite(RED_LED, LOW);   // Turn the red LED off
  Serial.println("LED off");    // Print message
  delay(1000);
}
