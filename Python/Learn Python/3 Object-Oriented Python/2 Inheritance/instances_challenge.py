# Alright, here's a fun task!

# Create a function named combiner that takes a single argument,
# which will be a list made up of strings and numbers.

# Return a single string that is a combination of all of the strings
# in the list and then the sum of all of the numbers.
# For example, with the input ["apple", 5.2, "dog", 8],
# combiner would return "appledog13.2".
# Be sure to use isinstance to solve this as I might try to trick you

# failed try one
# def combiner(string_list):
#     combo_string = []
#     combo_nums = 0
#     for items in string_list:
#         if isinstance(items, str) is True:
#             combo_string.append(items)
#         elif isinstance(items, (int, float)) is True:
#             combo_nums += items

#     combo_string.append(combo_nums)

#     return combo_string

# failed two
# def combiner(string_list):
#     combo_string = ""
#     combo_nums = 0
#     for items in string_list:
#         if isinstance(items, str) is True:
#             combo_string.append(items)
#         elif isinstance(items, (int, float)) is True:
#             combo_nums += items

#     combo_string.append(combo_nums)

#     return "{}{}".format(combo_string, combo_nums)


def combiner(string_list):
    combo_string = ""
    combo_nums = 0
    for items in string_list:
        if isinstance(items, str):
            combo_string += items
        elif isinstance(items, (int, float)):
            combo_nums += items
    return "{}{}".format(combo_string, combo_nums)
