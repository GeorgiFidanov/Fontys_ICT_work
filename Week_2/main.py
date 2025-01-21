import random


def check_the_password():
    password = 'banana'
    print(f"{password} <--you don't see this")

    attempt_1 = input("Please enter your password: ")
    if attempt_1 == password:
        print("Congrats, you're in!")
    else:
        print("Your password is incorrect")
        attempt_2 = input("Please enter your password again: ")
        if attempt_2 == password:
            print("Congrats, you're in!")
        else:
            print("Your password is incorrect")
            attempt_3 = input("Please enter your password (last chance): ")
            if attempt_3 == password:
                print("Congrats, you're in!")
            else:
                print("Your password is incorrect")
                print("Your account has been blocked")


def find_the_classroom():

    student_name = input("Please enter your name: ")
    classes = {
        "Programing" : "401",
        "Swimming" : "402",
        "Dancing" : "403",
        "Psychology" : "404",
        "Science" : "405",
        "Math" : "406",
        "Reading" : "407",
        "Gooning" : "408"
    }

    student_class = input("Please enter your class: ")

    if student_class in classes:
        print(f"{student_name} your room is: {classes[student_class]}")

    else:
        print("I don't know in which room is this class")


def print_the_tallest_player():

    name_1 = input("Please enter the name of the first player: ")
    height_1 = input("Please enter the height of the first player: ")

    name_2 = input("Please enter the name of the second player: ")
    height_2 = input("Please enter the height of the second player: ")

    name_3 = input("Please enter the name of the third player: ")
    height_3 = input("Please enter the height of the third player: ")

    max_height = max(height_1, height_2, height_3)

    if max_height == height_1:
        print(f"The highest player is: '{name_1}' with height of '{height_1}'")
    elif max_height == height_2:
        print(f"The highest player is: '{name_2}' with height of '{height_2}'")
    elif max_height == height_3:
        print(f"The highest player is: '{name_3}' with height of '{height_3}'")
    elif max_height == height_1 == height_2:
        print(f"The highest players are: '{name_1}' and '{name_2}' with the height of '{height_1}'")
    elif max_height == height_1 == height_3:
        print(f"The highest players are: '{name_1}' and '{name_3}' with the height of '{height_1}'")
    elif max_height == height_3 == height_2:
        print(f"The highest players are: '{name_2}' and '{name_3}' with the height of '{height_2}'")
    elif max_height == height_1 == height_2 == height_3:
        print(f"The players are the same height: '{height_1}'")


def guess_the_number_game(repeatability):
    best_score = repeatability
    current_score = 0
    current_number = random.randint(1, 100)

    while True:
        current_guess = int(input("Please guess a number between 1 and 100: "))
        if current_guess > 100:
            print("The number you enter must be between 1 and 100!")
            current_guess = int(input("Please guess a number between 1 and 100: "))

        if current_guess < 1:
            print("The number you enter must be between 1 and 100!")
            current_guess = int(input("Please guess a number between 1 and 100: "))

        current_score += 1
        if current_guess == current_number:
            if current_score < best_score:
                best_score = current_score
            print(f"You're correct the number was: {current_number} and your score is {current_score}")
            print(f"Your best score is {best_score}")
            answer = input("Would you like to play again? j/n ")
            if answer == "j":
                guess_the_number_game(best_score)
            else:
                exit()

        elif current_guess > current_number:
            print("Your guess is too high")

        elif current_guess < current_number:
            print("Your guess is too low")


def inform_the_boss():
    bunches_sold = 0
    most_expensive_bunch_sold = 0
    cheapest_bunch_sold = 10000
    total_profit = 0
    name_of_the_most_expensive_bunch = 'None'
    name_of_the_cheapest_bunch = 'None'

    while True:
        operation = input("To make a new sale please type: 'S' for information: 'I' or 'Q' to quit: ")
        if operation == "S":
            flower = input("Please enter the name of the newly sold flower: ")
            money = int(input("Please enter the amount of the newly obtained money: "))

            bunches_sold += 1
            total_profit += money

            if money > most_expensive_bunch_sold:
                most_expensive_bunch_sold = money
                name_of_the_most_expensive_bunch = flower

            if money < cheapest_bunch_sold:
                cheapest_bunch_sold = money
                name_of_the_cheapest_bunch = flower

        elif operation == "I":
            print(f"Total number of bunches sold: {bunches_sold}")
            print(f"The most expensive bunch was priced at: {most_expensive_bunch_sold} "
                  f"and it was: {name_of_the_most_expensive_bunch}")
            print(f"The cheapest bunch was priced at: {cheapest_bunch_sold} "
                  f"and it was: {name_of_the_cheapest_bunch}")

            if bunches_sold < 1:
                print(f"The average price of the bunches sold is: 0")

            else:
                print(f"The average price of the bunches sold is: {total_profit / bunches_sold}")

        elif operation == "Q":
            exit()

        else:
            print("Please enter only valid operations! (S/I/Q)")


def check_if_letter_is_in():
    letter = input("Please enter the letter: ")
    alphabet = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t",
                "u", "v", "w", "x", "y", "z"}
    if letter in alphabet:
        print("Yes")
    else:
        print("No")
