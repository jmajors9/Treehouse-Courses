# how to write funcs
#  no numbers, hypens, spaces, special chars
def hows_the_parrot():
    print("He's pining for the fjords!")

hows_the_parrot()

def lumberjack(name, pronoun):
    print("{}'s a lumberjack and {} OK!".format(name, pronoun))
    # print("{} sleeps all night and {} works all day!".format(name, name))

lumberjack("Joel", "he's")
lumberjack("Elaine", "she's")
lumberjack("Sam", "they're")
# lumberjack() definitely throws an error

def average(num1, num2):
    return(num1+num2) / 2

# average(2,8)
# this doesn't print anything! let's assign to a var
avg = average(2,8)
print(avg)
