alpha_list = ["a", "b", "z", "c", "d"]

del alpha_list[2]
# removes the z

# what if you don't know the number of the item?
my_list = [1, 2, 3, 1]

my_list.remove(1)
# my_list is now [2, 3, 1]

my_list.remove(1)
# now it removes 1

my_list.remove(1)
#  now throws an error... but we can do a loop!


# def disemvowel(word):
#     try:
#         del word["a"]
#         del word["e"]
#         del word["i"]
#         del word["o"]
#         del word["u"]
#     except ValueError:
#         pass
#     return word


def disemvowel(word):
    for letter in word:
        if letter.lower() not in 'aeiou':
            word += letter
    return word
