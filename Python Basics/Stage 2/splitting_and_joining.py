str(5)
list(5)
# ints are not iterable

list('hello')
['h', 'e', 'l', 'l', 'o']
'hello'.split()
['hello']

'hello there students'.split()
['hello', 'there', 'students']

"red:blue:green".split(':')
['red', 'blue', 'green']

# turn a list into a string

flavors = ['chocolate', 'mint', 'strawberry']
# join lists into strings by using a string
', '.join(flavors)
'chocolate, mint, strawberry'

"My favorite flavors are: " + ', '.join(flavors)
'My favorite flavors are: chocolate, mint, strawberry'

"My favorite flavors are: {}".format(", ".join(flavors))
'My favorite flavors are: chocolate, mint, strawberry'
# function call inside a function call! happens a lot in python
# can't use join on a list that no strings in it.


