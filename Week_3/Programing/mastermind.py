import random


def generate_code():
    return [random.randint(1, 6) for _ in range(4)]


def user_code():
    while True:
        code = input("Enter a 4-digit secret code (digits 1-6): ")
        if len(code) == 4 and all(digit in '123456' for digit in code):
            return [int(digit) for digit in code]
        print("Invalid input. Make sure to enter 4 digits between 1 and 6.")


def get_guess():
    while True:
        guess = input("Enter your 4-digit guess (digits 1-6): ")
        if len(guess) == 4 and all(digit in '123456' for digit in guess):
            return [int(digit) for digit in guess]
        else:
            print("Invalid input. Make sure to enter 4 digits between 1 and 6.")


def evaluate_guess(code, guess):
    code_copy = code.copy()
    guess_copy = guess.copy()

    bulls = 0
    cows = 0

    for i in range(4):
        if guess_copy[i] == code_copy[i]:
            bulls += 1
            code_copy[i] = None
            guess_copy[i] = None

    for i in range(4):
        if guess_copy[i] is not None and guess_copy[i] in code_copy:
            cows += 1
            code_copy[code_copy.index(guess_copy[i])] = None

    return bulls, cows


def mastermind():
    print("Welcome to Mastermind! (bulls and cows)")
    choice = input("Would you like to (1) generate a random code or (2) input your own secret code: ")

    if choice == '1':
        secret_code = generate_code()
    else:
        secret_code = user_code()

    max_attempts = 12
    attempts = 0

    while attempts < max_attempts:
        guess = get_guess()
        attempts += 1

        bulls, cows = evaluate_guess(secret_code, guess)
        print(f"Bulls (Correct position): {bulls}, Cows (Wrong position): {cows}")

        if bulls == 4:
            print(f"Congratulations! You've guessed the code {secret_code} in {attempts} attempts.")
            play_again()
        else:
            print(f"Attempt {attempts}/{max_attempts}. Keep trying!")

    if attempts == max_attempts:
        print(f"Sorry, you've used all {max_attempts} attempts. The secret code was: {secret_code}")
        play_again()


# Function to ask if the player wants to play again
def play_again():
    while True:
        answer = input("Do you want to play again? (yes/no): ")
        if answer in ['yes', 'y', 'YES', 'Y']:
            mastermind()
        elif answer in ['no', 'n', 'No', 'NO', 'N']:
            exit()
        else:
            print("Invalid input. Please answer with 'yes' or 'no'. (HE HE HE)")


mastermind()
