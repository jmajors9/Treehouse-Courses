# Our game's player only has two attributes, x and y coordinates.
# Let's practice with a slightly different one, though.
# This one has x, y, and "hp", which stands for hit points.

# Our move function takes this three-part tuple player
# and a direction tuple that's two parts,
# the x to move and the y
# (like (-1, 0) would move to the left but not up or down).

# Finish the function so that if the player is being run into a wall,
# their hp is reduced by 5. Don't let them go past the wall.
# Consider the grid to be 0-9 in both directions.
# Don't worry about keeping their hp above 0 either


# EXAMPLES:
# move((1, 1, 10), (-1, 0)) => (0, 1, 10)
# move((0, 1, 10), (-1, 0)) => (0, 1, 5)
# move((0, 9, 5), (0, 1)) => (0, 9, 0)

def move(player, direction):
    x, y, hp = player
    xd, yd = direction

    if xd == -1 and x == 0:
        hp -= 5
    elif xd == 1 and x == 9:
        hp -= 5
    elif yd == -1 and y == 0:
        hp -= 5
    elif yd == 1 and y == 9:
        hp -= 5
    else:
        x += xd
        y += yd

    return x, y, hp
