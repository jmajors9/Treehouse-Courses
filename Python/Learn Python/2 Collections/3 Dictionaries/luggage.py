
# new ** thing?
# kwargs keyword arguments


def packer(**kwargs):
    print(kwargs)


packer(name="Joel", num=42, spanish_inquisition=None)

# new ** thing?
# kwargs keyword arguments


def packer2(name=None, **kwargs):
    print(kwargs)

# removes the name from the printing


def unpacker(first_name=None, last_name=None):
    if first_name and last_name:
        print("Hi {} {}!".format(first_name, last_name))
    else:
        print("Hi no name!")

# call unpacker(**{"last_name": "Love", "first_name": "Kenneth"})
# keyword params don't have to be in order

# CHALLENGE
# You've used the string .format() method before to fill in blank placeholders.
# If you give the placeholder a name, though, like in template below,
# you fill it in through keyword arguments to .format(), like this:

# template.format(name="Kenneth", food="tacos")

# Write a function named string_factory that accepts a list of dictionaries
# as an argument. Return a new list of strings made by using ** for each
# dictionary in the list and the template string provided

# Example:
# values = [{"name": "Michelangelo", "food": "PIZZA"},
# {"name": "Garfield", "food": "lasagna"}]

# string_factory(values)
# ["Hi, I'm Michelangelo and I love to eat PIZZA!",
# "Hi, I'm Garfield and I love to eat lasagna!"]


template = "Hi, I'm {name} and I love to eat {food}!"


def string_factory(list_of_dict):
    new_list = []
    for d in list_of_dict:
        new_list.append(template.format(**d))
    return new_list
