# we need to import stuff
import random

# version 1 (see number_game.py)
# generate a rand number between 1 and 10
# in a lot of languages you request a randno,
# it gives you a float below 1 and then you mult by ten and round off...
# that's crazy
# setting minimum

# version 2
# we're going to:
# safely make an int
# Limit the number of guesses
# print "too low" or "too high" messages for bad guesses
# let people play again


def game():
    secret_num = random.randint(1, 10)
    guesses = []

    while len(guesses) < 5:
        try:
            guess = int(input("Guess a number between 1 and 10: "))
        except ValueError:
            print("{} isn't a number!".format(guess))
        else:
            if guess == secret_num:
                print("You got it! My number was {}".format(secret_num))
                break
            elif guess < secret_num:
                print("My number is higher than {}".format(guess))
            else:
                print("My number is lower than {}".format(guess))
            guesses.append(guess)
    else:  # runs after the loop finished
        print("You didn't get it! My number was {}".format(secret_num))

    play_again = input("Do you want to play again? Y/n")
    if play_again.lower() != 'n':
        game()
    else:
        print("Bye!")


game()
