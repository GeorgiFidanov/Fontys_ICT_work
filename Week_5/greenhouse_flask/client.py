import requests
import json

input_file = "data.json"  # The JSON file with sensor data
url = "http://localhost:8000/post_data"  # My local url


with open(input_file, 'r') as file:
    sensor_data = json.load(file)


for item in sensor_data:
    response = requests.post(url, json=item)

    if response.status_code == 200:
        print(f"Data posted successfully: {response.json()}")
    else:
        print(f"Failed to post data: {response.text}")
