def average(numbers):
    total = 0
    for number in numbers:
        total += number

    elements = len(numbers)
    return round(total / elements, 2)


def input_numbers():
    data = []
    while True:
        try:
            current_input = int(input("Enter a number: "))
            data.append(current_input)
        except ValueError:
            break
    return data


def average_segment(numbers):
    counter = 0
    week_total = []
    weeks_avg = []
    for number in numbers:
        week_total.append(number)
        counter += 1
        if counter == 7:
            average_week = average(week_total)
            weeks_avg.append(average_week)
            counter = 0

    for week in weeks_avg:
        print(week)

    return weeks_avg


def average_month(numbers):
    counter = 0
    month_avg = []
    month = []
    for number in numbers:
        month.append(number)
        counter += 1
        if counter == 4:
            month_avg.append(average(month))
            counter = 0

    for month in month_avg:
        print(month)


# This is task 3, 4 and 5 together done by recursion
def average_for_amount(days, amount):
    counter = 0
    month_avg = []
    month = []
    for day in days:
        month.append(day)
        counter += 1
        if counter == amount:
            month_avg.append(average(month))
            counter = 0

    if amount == 7:
        average_for_amount(month_avg, 4)

    if amount == 4:
         for month in month_avg:
             print(month)

average_month(average_segment(input_numbers()))

