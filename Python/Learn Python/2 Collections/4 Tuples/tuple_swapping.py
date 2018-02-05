# packing and unpacking is called
# swapping

a = 5
b = 20

# need a = 20 and b =5 wihtout using a C

a, b = b, a
# done

a = 5
b = 20
c = b, a

# each item in the tuple unpacks into the variable on the left side


def add(*nums):
    total = 0
    for num in nums:
        total += num
    return total


add(5, 5)
# we get 10

# could rewrite as


def add(base, *args):
    total = base
    for num in args:
        total += num
    return total
