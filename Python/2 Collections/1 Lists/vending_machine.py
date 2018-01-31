sodas = ["Pepsi", "Cherry Cokde Zero", "Sprite"]
chips = ["Doritos", "Fritos"]
candy = ["Snickers", "M&Ms", "Twizzlers"]

while True:
    choice = input("would you like a SODA, some CHIPS or CANDY? ").lower()
    try:
        if choice == 'soda':
            snack = sodas.pop()
        elif choice == 'chips':
            snack = chips.pop()
        elif choice == 'candy':
            snack = candy.pop()
        else:
            print("Sorry, I didn't udnerstand that.")
            continue
    except IndexError:
        print("We're all out of {}! Sorry!".format(choice))
    else:
        print("Here's your {}: {}".format(choice, snack))
