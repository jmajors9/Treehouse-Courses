List<string> students = new List<string>();
students.Add("Sue");
{"Sue"}

students.Add("Bill");
students.Add("Allen");
students.Count
3
students[0]
"Sue"

students[students.Count-1];
"Allen"

students.Capacity
4

// but we only had 3?
//it's just creating an array with an extra space
// List is default of 4
// add a fourth, fifth?
students.Add("Beth");
students.Add("Mary");
students.Count
5
students.Capacity
8
/*
now created new array of length 8
copied all of the old to this new one.

adding and removing items from lists can still be rather slow.
best to give a particular capacity to being with
*/

List<string> students = new List<string>(500);

/*
the array is encapsulated within the object list.
other things only reference List, not an array.

Lists become the most common collection type used in programming
*/

// MORE LIST OPERATIONS

// collection initializer
List<string> students = new List<string>(){ "Sue", "Bill", "Allen" };


students.sort()
students
// sorted them alphabetically
//looking up IComparable docs

