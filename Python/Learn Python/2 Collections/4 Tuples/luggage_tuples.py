def packer(name=None, **kwargs):
    print(kwargs)


def unpacker(first_name=None, last_name=None):
    if first_name and last_name:
        print("Hi {} {}!".format(first_name, last_name))
    else:
        print("Hi no name!")


packer(name="Joel", num=42, spanish_inquisition=None)
unpacker(**{"last_name": "Majors", "first_name": "Joel"})

course_minutes = {"Python Basics": 232,
                  "Django Basics": 237,
                  "Flash Basics": 189,
                  "Java Basics": 133}


for course, minutes in course_minutes.items():
    print("{} is {} minutes long".format(course, minutes))

# functionality that can work for mult types have not been
# rewritten for methods for each data type

list(enumerate("abc"))
# returns
[(0, 'a'), (1, 'b'), (2, 'c')]


for index, letter in enumerate("abcdefghijklmnopqrstuvwxyz"):
    print("{}: {}".format(index + 1, letter))

# which is much shorter than:
count = 1
for letter in "abcdefghijklmnopqrstuvwxyz":
    print("{}: {}".format(count, letter))
    count += 1
