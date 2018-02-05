# Let's play with the *args pattern.

# Create a function named multiply that takes any number of arguments.
# Return the product (multiplied value) of all of the supplied arguments.
# The type of argument shouldn't matter.

# Slices might come in handy for this one.


def multiply(*args):
    product = 1
    for arg in args:
        product *= arg
    return product
