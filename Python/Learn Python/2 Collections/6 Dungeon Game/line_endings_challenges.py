# OK, here's a...weird...set of tiles.
# I need you to loop through TILES and print out each item.
# Print each item on the same line unless the item is a double pipe (||).
# In that case, instead of printing the item, print a new line (\n).
# Use the end argument to print() to control whether things
#  print on a new line or not.


TILES = ('-', ' ', '-', ' ', '-', '||',
         '_', '|', '_', '|', '_', '|', '||',
         '&', ' ', '_', ' ', '||',
         ' ', ' ', ' ', '^', ' ', '||'
)

# NOPE
# for tile in TILES:
#     if tile != '||':
#         print(tile, end=" ")
#     else:
#         print("\n")

for tile in TILES:
    if tile != '||':
        print(tile, end="")  # just had to remove the space!
    else:
        print("\n")
