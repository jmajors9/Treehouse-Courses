/*
Set Operations:

* Distinct
* Except - often called a diff in other languages
  getting the elements from the first sequence that don't overlap entries in the second
* Union - takes two sequences and returns the elements in both sets but removes duplicates.
* Intersect - takes two sequences and returns the elements they have in common
* Concat - works like intersect, but returns everything. all colors and duplicates.

*/

birds.Select(b => b.Color)
//returns the colors as a list, including several repeats
// distinct will give us the distinct instances

birds.Select(b => b.Color).Distinct()
// retunrs the colors as a list with no repeats

//next four operators examine two sequences at once

// * EXCEPT
var colors = new List<string> {"Pink", "Blue", "Teal"};
colors.Except(birds.Select(b=> b.Color).Distinct());
// returns pink and teal since they are not in the true list of bird colors.

// * UNION
colors.Union(birds.Select(b=> b.Color).Distinct())
// returns all the colors from both lists wth no duplicates
birds.Where(b => b.Color == "Blue")
//returns bluejay

// * INTERSECT
colors.Intersect(birds.Select(b=> b.Color).Distinct())
// returns Blue: the only color in both lists.

// * CONCAT
colors.Concat(birds.Select(b=> b.Color))

colors.Concat(birds.Select(b=> b.Color).Distinct())

colors.Union(birds.Select(b=> b.Color));

/* she best that Union is faster than Concat
 gets a set and iterates through each element
 adds each element. adds a boolean value
 the add method is in a class called Set

 looking at Concat
 uses concat iterator
 doesn't use a set
 uses DistinctIterator
 uses the same set class and iterating over the same sequence

 */