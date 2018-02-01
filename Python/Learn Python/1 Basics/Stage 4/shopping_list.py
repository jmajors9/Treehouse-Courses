# make a list for the items
shopping_list = []

# print instructions for how to use the app 
print("What should we do today?")
print("Enter 'DONE' to stop adding items.")

while True:
    # ask for new items
    new_item = input("> ")

    # be able to quit the app
    if new_item == 'DONE':
        break

    # add new items to the list
    shopping_list.append(new_item)

# print out the list
print("Here's your list:")
for item in shopping_list:
    print(item)

# add SHOW to show list
# type HELP to add help
