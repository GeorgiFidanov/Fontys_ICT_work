const int PIN_LED = 4;
int counter = 0;

void setup() {
  Serial.begin(9600);
  pinMode(PIN_LED, OUTPUT);
}

void loop() {
  String cmd;


  if (Serial.available()) {
    cmd = Serial.readStringUntil('\n');
    if (cmd == "LedOn") {
      digitalWrite(PIN_LED, HIGH);
    } else if (cmd == "LedOff") {
      digitalWrite(PIN_LED, LOW);
    }
  }


  Serial.println(counter);
  counter++;
  delay(1000);
}

// Since Python and Arduino cannot access the COM port at the same time
// We can either choose:
// Keep the Arduino Serial Monitor and send messages to switch the LED's state
// Or keep the Python program and be able to see the results in its terminal