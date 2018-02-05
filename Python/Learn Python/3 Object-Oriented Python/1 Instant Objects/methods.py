import random

# methods are funcs inside a class
# methods in classes are the actions that
# the instances in your class can do


class Thief:
    sneaky = True

    def pickpocket(self):
        # self? the instance that's using the method
        # you don't give args to self when you use the method
        # print("Called by {}".format(self))
        if self.sneaky:
            return bool(random.randint(0, 1))
        return False


joel = Thief()
joel.pickpocket()
# random result

Thief.pickpocket()
# type error. missing the required arg of self
Thief.pickpocket(joel)
# random result

# added called by
# passing instances

# we can always use self to talk about the current instance within the method
# let's check if our thief is sneaky before we attempt to pickpocket
joel.sneaky() = False
joel.pickpoket()  # now is False

