# used to only be able to use 
set([1,3,5])

#  but now we can use {}
# sets get sorted in a way that works best to python

low_primes = {1, 3, 5, 7, 11, 13}

low_primes.add(17)
# added 17

# can use update to add mult sets
low_primes.update({19, 23}, {2, 29})
# added stff. sweet.

# removing? .remove
# can't delete with index since set isn't sorted

low_primes.add(15)
low_primes.remove(15)
low_primes.remove(100)
# throws an error. not on the list


# discard
low_primes.discard(100)
# nothing! no errors, moves on

# pop() works, but few use it.
