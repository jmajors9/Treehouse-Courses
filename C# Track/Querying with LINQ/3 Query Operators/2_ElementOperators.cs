/*
Operator Methods Summary
Single -  Use when the element must be unique. Exception if more than one, or non exists.
First - Use if there culd be more than one, but you only need the first. Exception if no match.
Last - Use if there could be more than one, but you only need the last. Exception if no match.
ElementAt - Use if you know the exact position of the element. Exception if no match.

SingleOrDefault - Use only when the element must be unique, or it may not exist.
FirstOrDefault - Use if there could be more than one or none, but you only need the first.
LastOrDefault - Use if there could be more than one or none, but you only need the last.
ElementAtOrDefault - Use if you know the exact position of the element, but it might not be there.

*/

birds.Where(b => b.Name == "Crow").Single();
// returns crow
// or use predecate as parameter
birds.Single(b => b.Name == "Crow");
// same return
// what if we use single and there's no match?
birds.Single(b => b.Name == "Chickadee");
// invalid

// diff version of method
birds.SingleOrDefault(b => b.Name == "Chickadee");
//returns null
// if it doesn't find a match, returns a default value
//if using integers
var numbers = new List<int> {2, 4, 8, 26};

numbers.SingleOrDefault(n => n == 99);
// returns 0
// what if we use single and it matches more than one bird?
birds.Single();
// invalid. sequence contains more than one element

//FIRST and LAST

birds.First()
// first bird in list
birds.Last()
// last in list


birds.First(b => b.Color == "Red");
// getting first bird with color red
birds.First(b => b.Name == "Chickadee");
// invalid
birds.FirstOrDefault(b => b.Name == "Chickadee");
// null, no exception

// ELEMENT AT

int[] numbers = { 0, 1,2,3};
numbers[2]
// 2
numbers.ElementAt(2)
// 2
birds[0]
// cardinal

var redBirds = birds.Where(b => b.Color == "Red");
redBirds[0]
// error
//that didn't work because you can't use an indexer to access the items
// but can still use elementat
redBirds.ElementAt(0)
// can still use OrDefault to avoid exception
redBirds.ElementAtOrDefault(99);
// returns null
