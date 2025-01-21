import serial


# Note: replace "COM1" with the COM port of your Arduino
ser = serial.Serial("COM8", baudrate=9600, timeout=1)
while True:
# Prompt user for input
    user_input = input("Enter 1 to turn the LED ON, 2 to turn the LED OFF,"
                       " or q to quit: ")
    if user_input == "1":
        ser.write("LedOn".encode()) # Send command to turn LED on
        print("LED turned ON")
    elif user_input == "2":
        ser.write("LedOff".encode()) # Send command to turn LED off
        print("LED turned OFF")
    elif user_input.lower() == "q":
        print("Exiting program.")
        break # Exit the loop
    else:
        print("Invalid input, please enter 1, 2, or q.")

ser.close() # Close the serial connection
