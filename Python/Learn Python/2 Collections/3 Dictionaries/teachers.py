
# This challenge has several steps so take your time, read the instructions
# carefully, and feel free to experiment in Workspaces or on your own computer.

# For this first task, create a function named num_teachers that takes a single
# argument, which will be a dictionary of Treehouse teachers and their courses.

# The num_teachers function should return
# an integer for how many teachers are in the dict

# STAGE 1
# The dictionary will look something like:
# {'Andrew Chalkley': ['jQuery Basics', 'Node.js Basics'],
#  'Kenneth Love': ['Python Basics', 'Python Collections']}
#
# Each key will be a Teacher and the value will be a list of courses.
#
# Your code goes below here.

# as always I got WAY too complicated. the right answer is below
def num_teachers(treehouse):
    return len(treehouse)


# STAGE 2
# That one wasn't too bad, right? Let's try something a bit more challenging.
#  Create a new function named num_courses that will receive the same
# dictionary as its only argument.
# The function should return the total number of courses for all of
# the teachers


def num_courses(treehouse):
    courses_no = 0
    for courses in treehouse:
        courses_no += len(treehouse[courses])
    return courses_no


# STAGE 3
# Great work! OK, you're doing great so I'll keep increasing the difficulty.

# For this step, make another new function named "courses" that will, again,
# take the dictionary of teachers and courses.

# "courses", though, should return a _single list_ of _all_ of the available
# courses in the dictionary. No teachers, just course names!

# first try
# def courses(treehouse):
#     course_list = []
#     for courses in treehouse:
#         course_list.append(treehouse[courses])
#     return course_list

# corrected
def courses(treehouse):
    course_list = []
    for courses in treehouse.values():
        course_list += courses
    return course_list

# STAGE 4
# Wow, I just can't stump you! OK, two more to go.
# I think this one's my favorite, though.

# Create a function named "most_courses" that takes our
# good ol' teacher dictionary.

# "most_courses" should return the name of the teacher with the most courses.
# You might need to hold onto some sort of max count variable


def most_courses(treehouse):
    max_count = 0
    most_teacher = ""
    for teacher, courses in treehouse.items():
        if len(courses) > max_count:
            max_count = len(courses)
            most_teacher = teacher
    return most_teacher

# STAGE 5
# It's official: you're awesome at Python dictionaries! One last task and then
# you can take a well-deserved break!

# In this last challenge, I want you to create a function named "stats" and
# it'll take our teacher dictionary as its only argument.

# "stats" should return a "list" of "lists" where the _first item_ in each
# inner "list" is the teacher's name and the _second item_ is the _number
# of courses_ that teacher has. For example, it might return:
# _[["Kenneth Love", 5], ["Craig Dennis", 10]]_


def stats(treehouse):
    stats_list = []
    count = 0
    for teacher, courses in treehouse.items():
        count = len(courses)
        stats_list.append([teacher, count])
    return stats_list
