favorite_things = ["raindrops on roses",
                   "whiskers on kittens",
                   "bright copper kettles",
                   "warm woolen mittens",
                   "bright paper packages tied up with string",
                   "cream colored ponies",
                   "crisp apple strudels"]

favorite_things[1:5]
# returns 2nd - 5th
# 1 is first index, 5 is NOT the last index, but it stops right before
# does not include the last indexed item

favorite_things[7]
# won't work. doesn't exist

favorite_things[5:999]
# gives the last two items

# if you leave off one of the numbers... slices will default to zero or end
# leaving off both gives the _whole_ list. A COPY of the list

messy_list = [4, 2, 1, 3, 5]

messy_list.sort()
# now it's ok. excep that the messy order is destroyed now

# now take the messy list from above
clean_list = messy_list[:]

clean_list.sort()

# now we have both lists and it's all good
