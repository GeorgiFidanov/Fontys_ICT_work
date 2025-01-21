const int BUTTON_PIN_1 = 8;  // Button for entering the site
const int BUTTON_PIN_2 = 9;  // Button for exiting the site
int peopleCount = 0;
bool buttonState1 = LOW;     
bool lastButtonState1 = LOW; 
bool buttonState2 = LOW;     
bool lastButtonState2 = LOW; 

void setup() {
  pinMode(BUTTON_PIN_1, INPUT);
  pinMode(BUTTON_PIN_2, INPUT);
  Serial.begin(9600);     
}

void loop() {

  buttonState1 = digitalRead(BUTTON_PIN_1);
  buttonState2 = digitalRead(BUTTON_PIN_2);

  if (buttonState1 == HIGH && lastButtonState1 == LOW) {
    peopleCount++;  
    Serial.print("People on site: ");
    Serial.println(peopleCount);
    delay(1000);
  }

  if (buttonState2 == HIGH && lastButtonState2 == LOW && peopleCount > 0) {
    peopleCount--;  
    Serial.print("People on site: ");
    Serial.println(peopleCount);
    delay(1000);
  }

  lastButtonState1 = buttonState1;
  lastButtonState2 = buttonState2;
}
