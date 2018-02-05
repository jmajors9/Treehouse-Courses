set1 = set(range(10))
set2 = {1, 2, 3, 5, 7, 11, 13, 17, 19, 23}
set1.union(set2)
# this doesn't change either set, but unifies them as an output
set1 | set2
# same thing

set1.difference(set2)
{0, 8, 4, 6, 9}
set2.difference(set1)
{19, 17, 11, 13, 23}
# same below
set1 - set2
set2 - set1

# symmetric difference
set1 ^ set2
{0, 4, 6, 8, 9, 11, 13, 17, 19, 23}
# or
set2.symmetric_difference(set1)

# intersection
set1.intersection(set2)
set2.intersection(set1)
{1, 2, 3, 5, 7}
# or
set1 & set2
{1, 2, 3, 5, 7}
