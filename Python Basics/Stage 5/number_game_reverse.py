# we need to import stuff
import random

# You think of a number.
# Have the computer make a guess and then adjust that guess
# based on whether you tell that the number was too high or too low.
# This will be harder than the version we built but I'm sure that you can do it


def game():
    secret_num = int(input("Give a number between 1 and 10: "))
    guesses = []

    while len(guesses) < 5:
        try:
            guess = random.randint(1, 10)
        except ValueError:
            print("{} isn't a number!".format(guess))
        else:
            if guess == secret_num:
                print("I got it! Your number was {}".format(secret_num))
                break
            elif guess != secret_num:
                print("Was your number {}?".format(guess))
                print("No, wait...")
    else:  # runs after the loop finished
        print("I didn't get it! Your number was {}".format(secret_num))

    play_again = input("Do you want to play again? Y/n ")
    if play_again.lower() != 'n':
        game()
    else:
        print("Bye!")
        exit()


game()
