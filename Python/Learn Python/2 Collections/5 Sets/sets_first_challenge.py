# Part One
# I think it's a good idea for you to experiment
# with sets since they're a very useful part of Python.

# Start by creating a set variable named songs that has
# three song titles in it. You can use any titles you want,
# just make sure they're three different strings.

# songs = set("Oval", "Windows", "Huggy Bear")
# too many in one entry

# songs = set("Oval")
# songs.update("Windows", "Huggy Bear")
# that works, but really, this is best:
songs = {"Oval", "Windows", "Huggy Bear"}


# Part Two
# Awesome. Now use the .add() method to add the title
# "Treehouse Hula" to songs

songs.add("Treehouse Hula")

songs.update({"Python Two-Step", "Ruby Rhumba"}, {"My PDF Files"})
