# in
if "java" in "javascript":
    print(True)
else:
    print(False)

if 5 in [1,2,3]:
    print(True)
else:
    print(False)

if "cheese" in "cheeseshop":
    print(True)
else:
    print(False)

cheeseshop = []
if "cheese" in cheeseshop:
    print(True)
else:
    print(False)

days_open = ['Monday', 'Tuesday', 'Wednesday', 'Thursday']
today = 'Tuesday'
if today in days_open:
    print("Come on in!")

today = 'Saturday'
if today in days_open:
    print("Come on in!")
else:
    print("Sorry, Closed")

if today not in days_open:
    print("Sorry, notin Closed")
