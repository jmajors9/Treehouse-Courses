trash = 99
del trash
# trash is gone now

alpha_list = list('abcde')

del alpha_list[2]
# works
del alpha_list[1,2]
# doesn't work

# can't delete things from a string
