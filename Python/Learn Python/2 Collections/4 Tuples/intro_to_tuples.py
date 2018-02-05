my_tuple = (1, 2, 3)
# tuple created

my_second_tuple = 1, 2, 3
#  this is a tuple too

# the commas are necesary!

my_third_tuple = (5)
# not a tuple

my_third_tuple = (5,)

# parenthesis are not necessary, but helpful.
dir(my_tuple)
# will give you all the stuff you can do. Not much!

# you can edit _stuff_ within a tuple, but you can't edit the tuple

tuple_with_a_list = (1, "apple", [3, 4, 5])

# can't change [0], [1]. ints and strings are immutable.

# strings are mutable
tuple_with_a_list[2][1] = 7
# gives a list of
[3, 7, 5]
# but you can't remove the list itself!
