# I need you to add a method name praise.
# The method should return a positive message about the student which
# includes the name attribute.
# As an example, it could say "You're doing a great job, Jacinta!"
# or "I really like your hair today, Michael!".

# Feel free to change the name attribute to your own name, too!


# class Student:
#     # first try. FAILED
#     name = "Joel"

#     def praise(self):
#         positive_message = ("You're doing great, {}!".format(self))
#         return positive_message


class Student:
    name = "Joel"

    def praise(self):
        return("You're doing great, {}!".format(self.name))
