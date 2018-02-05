# Challenge 1
# Our Student class is coming along nicely!

# I'd like to be able to set the name attribute at the same time that
# I create an instance. Can you add the code for doing that?
# Remember, you'll need to override the __init__ method.


class Student:
    name = "Your Name"

    def __init__(self, name, **kwargs):
        self.name = name

        for key, value in kwargs.items():
            setattr(self, key, value)

    def praise(self):
        return "You inspire me, {}".format(self.name)

    def reassurance(self):
        return "Chin up, {}. You'll get it next time!".format(self.name)

    def feedback(self, grade):
        if grade > 50:
            return self.praise()
        return self.reassurance()

    # Challenge 2
    # Great!

    # Sometimes I have other attributes I need to store on a Student instance,
    # though. Can you use **kwargs and setattr to add attributes for any other
    # key/value pairs I want to send to the instance when I create it?
