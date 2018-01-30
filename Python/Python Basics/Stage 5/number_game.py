# we need to import stuff
import random

#  generate a rand number between 1 and 10
#  in a lot of languages you request a randno,
# it gives you a float below 1 and then you mult by ten and round off...
# that's crazy
# setting minimum
secret_num = random.randint(1, 10)

while True:
    guess = int(input("Guess a number between 1 and 10: "))
# get a number guess from the player
    if guess == secret_num:
        print("You got it! My number was {}".format(secret_num))
        break
    else:
        print("That's not it!")
# compare guess to secret number
# print hit/miss
