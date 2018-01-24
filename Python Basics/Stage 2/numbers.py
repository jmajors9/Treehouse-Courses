# let's work with numbers
# python doesn't care what kind of nos. except with floats...

# int or ints or integers.
# basic + - * /

# 8 / 2 will give 4.0
# those are floats!

# 10 / 0 gives an error now

5.0 + 2.5
1.2 + 0.3

# they can sometimes do weird things.
0.1 + 0.1 + 0.1 - 0.3
5.551115123125783e-17
# use 
round(5.551115123125783e-17)
# rounds to the nearest whole no

#  what if we need to make an int frm a float?
int(5.551115123125783e-17)

# can change some strings to int
int('5')
not int('a')

# python does reg orders of ops
5+5*2 = 15

# can use () to control order, of course

age = 34
age +=7
age 
# result is 41
