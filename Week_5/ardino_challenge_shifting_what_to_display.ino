const int buttonPin = 8;        // My display and button are not working (physically) so this is mainly theoretical
const int tempPin = A1;
const int brightnessPin = A2;
const int dhtPin = 12;

int displayState = 0;           // To track the current state of the display
int lastButtonState = LOW;      // Previous state of the button
unsigned long debounceTime = 50; // Debounce time in milliseconds
unsigned long lastDebounceTime = 0;

void setup() {
  pinMode(buttonPin, INPUT_PULLUP);
  Serial.begin(9600);
}

void loop() {
  int reading = digitalRead(buttonPin);

  // Check if the button state has changed and apply a debounce delay
  if (reading != lastButtonState) {
    lastDebounceTime = millis();
  }

  if ((millis() - lastDebounceTime) > debounceTime) {
    if (reading == LOW && lastButtonState == HIGH) {
      displayState = (displayState + 1) % 4; // Cycle through 0, 1, 2, 3
      updateDisplay(displayState);
    }
  }

  lastButtonState = reading;
}

// Function to update the display state and print to Serial Monitor
void updateDisplay(int state) {
  Serial.println(); // Print a blank line for readability
  switch (state) {
    case 0:
      Serial.println("Display Off");
      break;
    case 1:
      Serial.print("Temperature: ");
      Serial.print(getTemperature());
      Serial.println(" C");
      break;
    case 2:
      Serial.print("Humidity: ");
      Serial.print(getHumidity());
      Serial.println(" %");
      break;
    case 3:
      Serial.print("Brightness: ");
      Serial.print(getBrightness());
      Serial.println(" lx");
      break;
  }
}

// Function to read the temperature from the NTC sensor
float getTemperature() {
  int sensorValue = analogRead(tempPin);
  float voltage = sensorValue * (5.0 / 1023.0);  // Convert to voltage
  float temperatureC = (voltage - 0.5) * 100;    // Simplified conversion for NTC
  return temperatureC;
}

// Function to read humidity from an analog humidity sensor
int getHumidity() {
  int sensorValue = analogRead(A1);  // Replace A1 with the appropriate pin for your sensor
  int humidity = map(sensorValue, 0, 1023, 0, 100);  // Convert the analog value to a percentage (0-100%) I think this way is the most convenient
  return humidity;
}


// Function to read brightness from the LDR sensor
int getBrightness() {
  return analogRead(brightnessPin);  // Direct reading from LDR sensor
}
