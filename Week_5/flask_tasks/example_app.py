from flask import Flask, render_template, jsonify
import datetime
import random

app = Flask(__name__)
samples = []

@app.route("/", methods=["GET"])
def home():
    # Generate light info
    current_time = datetime.datetime.now().strftime("%H:%M:%S")
    light_level = random.randint(0, 1000)

    # Append current light level to samples
    samples.append({
        "timestamp": current_time,
        "light_level": light_level
    })

    # Keep only the last 25 samples
    if len(samples) > 25:
        samples.pop(0)

    # Return the home page with current data and samples
    return render_template('example_index.html', current_time=current_time,
                           light_level=light_level, samples=samples)

@app.route("/samples", methods=["GET"])
def get_samples():
    # Return the samples as JSON
    return jsonify({"samples": [{"timestamp": s["timestamp"], "light_level": s["light_level"]} for s in reversed(samples)]})

@app.route("/display_samples", methods=["GET"])
def display_samples():
    return render_template('example_display_sample.html', samples=samples)

if __name__ == "__main__":
    app.run(debug=True, port=8000)
