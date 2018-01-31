rainbow = ["red",
           "orange",
           "green",
           "yellow",
           "blue",
           "black",
           "white",
           "aqua",
           "purple",
           "pink"]

del rainbow[5]

del rainbow[5:8]

rainbow
["red",
 "orange",
 "green",
 "yellow",
 "blue",
 "purple",
 "pink"]

# now yellow and green need to be reversed

rainbow[2:4] = ["yellow", "green"]
# works and replaces/ switches yellow and green
rainbow
["red",
 "orange",
 "yellow",
 "green",
 "blue",
 "purple",
 "pink"]

rainbow[4:5] = ["blue", "indigo"]
# adds indigo after replacing blue with blue
["red",
 "orange",
 "yellow",
 "green",
 "blue",
 "indigo",
 "purple",
 "pink"]

# now let's drop purple and pink when we add in violent for ROYGBIV
rainbow[-2:] = "violet"

["red",
 "orange",
 "yellow",
 "green",
 "blue",
 "indigo",
 "v",
 "i",
 "o",
 "l",
 "e",
 "t"]

# oops. now to fix that. letters are already there!
# let's use join
rainbow[-6:] = ["".join(rainbow[-6:])]
# so that's rainbow from the end to -6th place,
# taking the string of those items and joining then
# and then making them back into one item

# now should look just fine
