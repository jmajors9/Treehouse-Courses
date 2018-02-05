import random


class Thief:
    sneaky = True

    def __init__(self, name, sneaky=True, **kwargs):
        self.name = name
        self.sneaky = sneaky

        for key, value in kwargs.items():
            setattr(self, key, value)
            # setattr since we don't know name of attr to create,
            # let's us do this

    def pickpocket(self):
        return self.sneaky and bool(random.randint(0, 1))

    def hide(self, light_level):
        return self.sneaky and light_level < 10


# double underscore methods always happen if the class is called

# console
joel = Thief("Joel", False)

joel.name
"Joel"
joel.sneaky
False


# console
joel = Thief("Joel", scars=None, favorite_weapon="dagger")
joel.name
"Joel"
joel.scars
None
joel.favorite_weapon
"dagger"
