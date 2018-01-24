# strings are a group of items.
# lists are another kind of group. 
# lists are like arrays. it's the ultimate bag of holding

[1,2,3]
my_list = [1,2,3]
# my_list + 5 doesn't work

my_list + [4,5]
[1,2,3,4,5]
my_list
[1,2,3]

my_list = my_list + [4,5]
[1,2,3,4,5]
my_list += [6,7]
[1,2,3,4,5,6,7]

my_list * 2
[1,2,3,4,5,6,7,1,2,3,4,5,6,7]

my_list = [1,2,3,4,5]
my_list.append(6)

# cannot do 
my_list.append(7,8)
my_list.append([7,8])
[1,2,3,4,5,6,[7,8] ]

my_list.extend([4,5,6])

list_in_list = [1,2,3,[4,5,6]]
list_in_list.remove([4,5,6])
list_in_list
[1,2,3]
