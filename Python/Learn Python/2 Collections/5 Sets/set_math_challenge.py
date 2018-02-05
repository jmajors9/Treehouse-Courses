# Challenge Task 1 of 2
# Let's write some functions to explore set math a bit more.
# We're going to be using this
# COURSES
# dict in all of the examples.
# _Don't change it, though!_

# So, first, write a function named
# covers
# that accepts a single parameter, a set of topics.
# Have the function return a list of courses from
# COURSES
# where the supplied set and the course's value (also a set) overlap.

# For example,
# covers({"Python"})
# would return
# ["Python Basics"].


COURSES = {
    "Python Basics": {"Python", "functions", "variables",
                      "booleans", "integers", "floats",
                      "arrays", "strings", "exceptions",
                      "conditions", "input", "loops"},
    "Java Basics": {"Java", "strings", "variables",
                    "input", "exceptions", "integers",
                    "booleans", "loops"},
    "PHP Basics": {"PHP", "variables", "conditions",
                   "integers", "floats", "strings",
                   "booleans", "HTML"},
    "Ruby Basics": {"Ruby", "strings", "floats",
                    "integers", "conditions",
                    "functions", "input"}
}


# below did not work
# def covers(set_of_topics):
#     list_of_courses = []
#     for value in COURSES:
#         list_of_courses.append(value)

#    return list_of_courses


def covers(set_of_topics):
    # had to get help
    list_of_courses = []
    for key, value in COURSES.items():
        if value & set_of_topics:
            list_of_courses.append(key)

    return list_of_courses

# CHALLENGE 2 of 2
# Great work!

# OK, let's create something a bit more refined.
# Create a new function named
# covers_all
# that takes a single set as an argument.
# Return the names of all of the courses, in a list,
# where all of the topics in the supplied set are covered.

# For example,
# covers_all({"conditions", "input"})
# would return
# ["Python Basics", "Ruby Basics"].
# Java Basics and PHP Basics would be exclude because they
# don't include both of those topics


def covers_all(set_of_topics):
    course_list = []

    for course, value in COURSES.items():
        if (set_of_topics & value) == set_of_topics:
            course_list.append(course)

    return course_list
