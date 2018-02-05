class Thief:  # use TitleCase by convention
    sneaky = True
    pass

from characters import Thief
Joel = Thief()

# call Joel
<characters.Thief object at {} >
# {} spot in memory
# string

# added sneaky
# call Joel = Thief()
# dot syntax
# call Joel.sneaky
True
Joel.sneaky = False
but Thief.sneaky is still True

del Joel
get a name error
