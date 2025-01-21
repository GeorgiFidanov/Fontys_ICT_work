const int BUTTON_PIN = 8; 
int peopleCount = 0;      
bool buttonState = LOW;   
bool lastButtonState = LOW;

void setup() {
  pinMode(BUTTON_PIN, INPUT);
  Serial.begin(9600);     
}

void loop() {
  buttonState = digitalRead(BUTTON_PIN);

  // Check if button is pressed
  if (buttonState == HIGH && lastButtonState == LOW) {
    peopleCount++;  

    Serial.print("People on site: ");
    Serial.println(peopleCount);
    delay(1000);
  }

  lastButtonState = buttonState; // Store the button state for the next loop
}
