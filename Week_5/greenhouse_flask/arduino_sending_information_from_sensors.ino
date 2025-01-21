#include <SimpleDHT.h> /*https://github.com/winlinvip/SimpleDHT/archive/refs/heads/master.zip*/

const int dhtPin = 12;        // DHT sensor pin
const int brightnessPin = A2; // LDR sensor pin
SimpleDHT11 dht11;            // Create a DHT11 sensor object

void setup() {
  Serial.begin(9600);
}

void loop() {
  // Variables for sensor readings
  byte temperature = 0;  // Change to byte
  byte humidity = 0;     // Change to byte

  // Read temperature and humidity from DHT11
  int err = dht11.read(dhtPin, &temperature, &humidity, NULL);
  if (err != SimpleDHTErrSuccess) {
    Serial.println("Failed to read from DHT sensor!");
    return;
  }

  // Read brightness from the LDR sensor
  int brightness = analogRead(brightnessPin);

  // Prepare and send data as JSON
  String jsonData = "{\"sensor_id\": 5375290, \"timestamp\": " + String(millis()) +
                    ", \"temperature\": " + String(temperature) +
                    ", \"humidity\": " + String(humidity) +
                    ", \"light_level\": " + String(brightness) + "}";

  Serial.println(jsonData); // Output JSON to Serial for Python to read
  delay(2000);
}
