def guess_the_word(word):
    word_dict = list(word)
    guessed_letters = ["_" for _ in word_dict]
    used_letters = []
    attempts = 6

    while attempts > 0:

        print(f"Lives left: {attempts}")
        print("Word: " + " ".join(guessed_letters))
        print("Used letters: " + " ".join(used_letters))

        # Get the user's guess
        guess = input("Guess a letter or the whole word: ").lower()

        if len(guess) == 1:
            if guess in used_letters:
                print(f"You already guessed {guess}. Try again.")
            else:
                used_letters.append(guess)
                if guess in word_dict:
                    print(f"Good job! {guess} is in the word.")

                    for i, letter in enumerate(word_dict):
                        if letter == guess:
                            guessed_letters[i] = guess
                else:
                    print(f"Sorry, {guess} is not in the word.")
                    attempts -= 1
        elif len(guess) > 1:
            if guess == word:
                print(f"Wow you win! The word is {word}")
                break
            else:
                print(f"Sorry, {guess} wasn't the word!")
                attempts -= 1

        if "_" not in guessed_letters:
            print(f"Congratulations! You've guessed the word: {word}")
            break

        if attempts == 0:
            print(f"Game over! The word was {word}")


guess_the_word("python")
