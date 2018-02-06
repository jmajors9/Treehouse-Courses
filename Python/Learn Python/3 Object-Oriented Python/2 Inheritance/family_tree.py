isinstance('a', str)
# will tell you if something is an instance of an object
True

isinstance(5.2, (str, book, dict))
False
isinstance(True, int)
True
# why? I think because 0 is false and 1 is true?
# I'm right. google

issubclass(bool, int)
True
# will take a list or tuple to compare against

from thieves import Thief
from characters import Character
issubclass(Thief, Character)
True

kenneth = Thief(name="Kenneth")
type(kenneth)
<class 'thieves.Thief'>
# but this won't tell us if he's a character...

