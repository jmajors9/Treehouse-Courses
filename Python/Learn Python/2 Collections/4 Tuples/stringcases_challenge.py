# Create a function named stringcases that takes a single string
# but returns a tuple of different string formats. The formats should be:

#   All uppercase
#   All lowercase
#   Titlecased (first letter of each word is capitalized)
#   Reversed

# There are str methods for all but the last one.


# def stringcases(single_string):
#     upper_string = single_string.upper()
#     lower_string = single_string.lower()
#     title_string = single_string.title()
#     reverse_string = single_string[::-1]

#     tuple_strings = (upper_string,
#                      lower_string,
#                      title_string,
#                      reverse_string)
#     return tuple_strings

# smaller
def stringcases(single_string):
    upper_string = single_string.upper()
    lower_string = single_string.lower()
    title_string = single_string.title()
    reverse_string = single_string[::-1]

    return (upper_string,
            lower_string,
            title_string,
            reverse_string)
