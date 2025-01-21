const int POTPIN = A0;
const int LED1 = 7;
const int LED2 = 6;
const int LED3 = 5;
const int LED4 = 4;

void setup() {
  pinMode(POTPIN, INPUT);
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);
}

void loop() {
  int val = analogRead(POTPIN);
  int persentage = map(val, 0, 1023, 0, 100);
  
  if(persentage <= 25){
    digitalWrite(LED1, HIGH);
    digitalWrite(LED2, LOW);
    digitalWrite(LED3, LOW);
    digitalWrite(LED4, LOW);
  }

  if(persentage > 25){
    digitalWrite(LED1, LOW);
    digitalWrite(LED2, HIGH);
    digitalWrite(LED3, LOW);
    digitalWrite(LED4, LOW);

    if(persentage > 50){
      digitalWrite(LED1, LOW);
      digitalWrite(LED2, LOW);
      digitalWrite(LED3, HIGH);
      digitalWrite(LED4, LOW);

      if(persentage > 75){
        digitalWrite(LED1, LOW);
        digitalWrite(LED2, LOW);
        digitalWrite(LED3, LOW);
        digitalWrite(LED4, HIGH);
      }
    }
  }
}
