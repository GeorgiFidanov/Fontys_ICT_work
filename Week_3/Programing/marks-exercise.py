
""" 
Analysing marks in Long Jump
This version is incomplete. Implement the functions as needed to make it work

"""


def read_marks(nameOfPlayer):
    """ Assumes 'nameOfPlayer' is a (non-empty) string.
        Reads from input either integer numbers or
        'x' indicating a failed jump attempt, and
        builds a list of marks, each of which is either
        an integer or a None-value indicating failure.
        Returns the resulting list of marks. """

    marks = []
    while True:
        user_input = input(
            f"Enter jump mark for player {nameOfPlayer} (or 'x' for a failed attempt, or press Enter to stop): ")
        if user_input == "":
            break
        elif user_input == "x":
            marks.append(None)
        else:
            try:
                mark = int(user_input)
                marks.append(mark)
            except ValueError:
                print("Invalid input. Please enter a valid integer or 'x'.")

    return marks


# Function for calculating the best mark of a player:
def find_best(marks):
    """ Assumes 'marks' is a list of integers and None-values.
        Returns None if there are no integers in list 'marks',
                or the highest number in it otherwise. """

    valid_marks = [mark for mark in marks if mark is not None]  # Filter out None values
    if valid_marks:
        return max(valid_marks)
    else:
        return None


# Function for calculating the winner or winners,
# given their best marks:
def determine_winner(nameA, nameB, bestA, bestB):

    """ Assumes 'bestA' and 'bestB' are each either None or an integer.
        Returns a list possibly including each of 'nameA' and 'nameB'
                depending on the best marks between 'bestA' and 'bestB'. """

    if bestA == None:
        if bestB == None:
            winners = []
        else:
            winners = [nameB]
    else:
        if bestB == None:
            winners = [nameA]
        else:
            if bestA > bestB:
                winners = [nameA]
            elif bestA < bestB:
                winners = [nameB]
            else:
                winners = [nameA, nameB]
    
    return winners

# Function for outputting the winner or winners,
# if there are any:
def output_winner_result(namesOfWinners):

    """ Assumes 'namesOfWinners' is a list of strings.
        Returns nothing but prints a result. """

    if len(namesOfWinners) == 0:
        print("Nobody wins.")
    elif len(namesOfWinners) == 1:
        print("Player", namesOfWinners[0], "wins.")
    else:
        print("It is a tie between player", namesOfWinners[0],
                "and player", namesOfWinners[1] + ".")

# Main program:
# Read the marks for both player A and player B:
marksA = read_marks("A")
marksB = read_marks("B")
# Calculate the best mark for both player A and player B:
bestA = find_best(marksA)
bestB = find_best(marksB)
# Calculate the winners and output the result:
winners = determine_winner("A", "B", bestA, bestB)
output_winner_result(winners)
