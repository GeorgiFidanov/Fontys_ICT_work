from flask import Flask, render_template, jsonify, request
import datetime
from collections import defaultdict
import matplotlib.pyplot as plt
import os


app = Flask(__name__)
samples = []


@app.route("/", methods=["GET"])
def home():
    # Display the most recent sensor data if available
    latest_sample = samples[-1] if samples else {
        "timestamp": "No data yet",
        "temperature": "N/A",
        "humidity": "N/A",
        "light_level": "N/A",
        "sensor_id": "N/A"
    }

    # Calculate statistics for each sensor
    sensor_stats = calculate_sensor_statistics(samples)

    # Render the homepage with the most recent data and sensor statistics
    return render_template('index.html', latest_sample=latest_sample,
                           samples=samples, sensor_stats=sensor_stats)


@app.route("/get_latest_data", methods=["GET"])
def get_latest_data():
    return jsonify(samples)


@app.route("/post_data", methods=['POST'])
def receive_data():
    try:
        # Handle the incoming JSON data
        json_data = request.json
        if json_data is None:
            return jsonify({"message": "No data received"}), 400  # Bad Request

        # Extract data from the JSON payload
        timestamp = json_data.get('timestamp', datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S"))
        temperature = json_data.get('temperature')
        humidity = json_data.get('humidity')
        light_level = json_data.get('light_level')
        sensor_id = json_data.get('sensor_id', "Unknown Sensor")

        # Check if required data is missing
        if temperature is None or humidity is None or light_level is None:
            return jsonify({"message": "Missing data in the request"}), 400  # Bad Request

        # Add the received data to the samples list
        samples.append({
            "timestamp": timestamp,
            "temperature": temperature,
            "humidity": humidity,
            "light_level": light_level,
            "sensor_id": sensor_id
        })

        # Keep only the last 25 samples
        if len(samples) > 25:
            samples.pop(0)

        # Respond with a success message
        return jsonify({"message": "Data received successfully"}), 200

    except Exception as e:
        return jsonify({"message": "Error processing data", "error": str(e)}), 500  # Internal Server Error


#for the dynamic refresh
@app.route("/display_samples", methods=["GET"])
def display_samples():
    return render_template('display_sample.html', samples=samples)


def calculate_sensor_statistics(samples_data):
    """Calculate average, min, and max values for each sensor."""
    sensor_data = defaultdict(list)

    # Organize data by sensor ID
    for sample in samples_data:
        sensor_data[sample['sensor_id']].append({
            'temperature': sample['temperature'],
            'humidity': sample['humidity'],
            'light_level': sample['light_level']
        })

    sensor_stats = {}
    for sensor_id, readings in sensor_data.items():
        temperatures = [float(r['temperature']) for r in readings]
        humidity_values = [float(r['humidity']) for r in readings]
        light_levels = [float(r['light_level']) for r in readings]

        sensor_stats[sensor_id] = {
            'average_temperature': round(sum(temperatures) / len(temperatures), 2),
            'max_temperature': round(max(temperatures), 2),
            'min_temperature': round(min(temperatures), 2),
            'average_humidity': round(sum(humidity_values) / len(humidity_values), 2),
            'max_humidity': round(max(humidity_values), 2),
            'min_humidity': round(min(humidity_values), 2),
            'average_light_level': round(sum(light_levels) / len(light_levels), 2),
            'max_light_level': round(max(light_levels), 2),
            'min_light_level': round(min(light_levels), 2),
        }

    return sensor_stats


@app.route("/select_sensor", methods=["POST"])
def select_sensor():
    sensor_id = request.form.get('sensor_id')
    filtered_samples = [s for s in samples if s['sensor_id'] == sensor_id]

    if filtered_samples:
        latest_sample = filtered_samples[-1]  # Get the most recent sample for the selected sensor
    else:
        latest_sample = {
            "timestamp": "No data yet",
            "temperature": "N/A",
            "humidity": "N/A",
            "light_level": "N/A",
            "sensor_id": sensor_id
        }

    # Calculate statistics for the selected sensor
    sensor_stats = calculate_sensor_statistics(filtered_samples)

    return render_template('index.html', latest_sample=latest_sample,
                           samples=filtered_samples, sensor_stats=sensor_stats)



@app.route("/plot")
def plot():
    # Create a directory for saving plots if it doesn't exist
    plot_dir = 'static/plots'
    os.makedirs(plot_dir, exist_ok=True)

    # Extract data for plotting
    timestamps = [sample['timestamp'] for sample in samples]
    temperatures = [float(sample['temperature']) for sample in samples if sample['temperature'] is not None]
    humidity_data = [float(sample['humidity']) for sample in samples if sample['humidity'] is not None]

    # Plotting
    plt.figure(figsize=(10, 5))
    plt.plot(timestamps[-len(temperatures):], temperatures, label='Temperature (°C)', color='r')
    plt.plot(timestamps[-len(humidity_data):], humidity_data, label='Humidity (%)', color='b')
    plt.xlabel('Timestamp')
    plt.xticks(rotation=45)
    plt.ylabel('Values')
    plt.title('Sensor Data Over Time')
    plt.legend()
    plt.tight_layout()
    plt.savefig(os.path.join(plot_dir, 'sensor_data.png'))
    plt.close()

    return render_template('plot.html', plot_url='/static/plots/sensor_data.png')


if __name__ == "__main__":
    app.run(port=8000)
