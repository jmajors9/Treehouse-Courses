# we need to handle exceptions! try is new
try:
    count = int(input("give me a number: "))
    # let's catch a value error. but it's except in python
except ValueError:
    print("That isn't a number!")
# what if it doesn't throw that exception?
else:
    print("Hi " * count)

# the above ok, but can be harder to work through.
