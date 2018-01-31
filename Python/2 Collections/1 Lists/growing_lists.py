favorite_things = ["raindrops on roses",
                   "whiskers on kittens",
                   "bright copper kettles"]

favorite_things + ["warm woolen mittens"]
# only adds

favorite_things += ["warm woolen mittens"]
# adds permanently


favorite_things.append(["bright paper packages tied up with string"])
# but that adds a list to the list

del favorite_things[-1]
# now removes that last list

favorite_things.append("bright paper packages tied up with string")
# now adds the right thing

favorite_things.extend(["cream colored ponies", "crisp apple strudels"])
# now should be great

# extend can add to something that isn't a list
a = [1, 2, 3]
a.extend("abc")
# a will return 1,2,3,'a','b','c'

del favorite_things[1]
# removes whiskers

# now lets use insert
favorite_things.instert(1, "whiskers on kittens")
# adds it back at the indicated spot in the list

# no equals signs used
#  lists are mutable, and that can come back to bite you sometimes
