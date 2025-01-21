from flask import Flask, render_template, jsonify
import datetime
import random

app = Flask(__name__)
samples = []
sensor_id = "5375290"

@app.route("/", methods=["GET"])
def home():
    # Generate simulated sensor data
    current_time = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    temperature = round(random.uniform(15.0, 40.0), 2)
    humidity = round(random.uniform(0.0, 100.0), 2)
    light_level = round(random.uniform(0, 1000), 2)


    samples.append({
        "timestamp": current_time,
        "temperature": temperature,
        "humidity": humidity,
        "light_level": light_level,
        "sensor_id": sensor_id
    })


    if len(samples) > 25:
        samples.pop(0)


    return render_template('index.html', current_time=current_time,
                           temperature=temperature, humidity=humidity,
                           light_level=light_level, sensor_id=sensor_id,
                           samples=samples)

@app.route("/samples", methods=["GET"])
def get_samples():
    # Return the samples as JSON
    return jsonify({"samples": [
        {
            "timestamp": s["timestamp"],
            "temperature": s["temperature"],
            "humidity": s["humidity"],
            "light_level": s["light_level"],
            "sensor_id": s["sensor_id"]
        } for s in reversed(samples)
    ]})

@app.route("/display_samples", methods=["GET"])
def display_samples():
    return render_template('display_sample.html', samples=samples)

if __name__ == "__main__":
    app.run(debug=True, port=8000)
