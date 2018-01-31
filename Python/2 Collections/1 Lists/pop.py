names = ["Kenneth", "Alena", "Sam", "Amjith"]

name_1 = names.pop()
name_1
'Amjith'

name_2 = names.pop(0)
name_2
"Kenneth"

names
["Alena", "Sam"]

messy_list = ["a", 2, 3, 1, False, [1, 2, 3]]

# Your code goes below here
messy_list.insert(0, messy_list.pop(3))
