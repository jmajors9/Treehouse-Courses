
course_minutes = {"Python Basics": 232,
                  "Django Basics": 237,
                  "Flask Basics": 189,
                  "Java Basics": 133}


for course in course_minutes:
    print(course)
    # but you only get the keys, not the values


for course in course_minutes:
    print(course_minutes[course])
# now you get the minutes
# only the minutes

# KEYS METHOD
for key in course_minutes.keys():
    print(key)

# VALUES METHOD
for value in course_minutes.values():
    print(value)

# TUPLE METHOD
for item in course_minutes.items():
    print(item)

# result
("Python Basics", 232)
("Django Basics", 237)
("Flask Basics", 189)
("Java Basics", 13)


