import random


class Character:
    def __init__(self, name, **kwargs):
        self.name = name

        for key, value in kwargs.items():
            setattr(self, key, value)


class Thief(Character):
    # inheriting from Character now
    sneaky = True

# even though we lost the way to initiate sneaky, we can use super to do it
    def __init__(self, name, sneaky=True, **kwargs):
        super().__init__(name, **kwargs)
        # calling super first in case someone passed in a sneaky kwarg
        self.sneaky = sneaky

    def pickpocket(self):
        return self.sneaky and bool(random.randint(0, 1))

    def hide(self, light_level):
        return self.sneaky and light_level < 10
