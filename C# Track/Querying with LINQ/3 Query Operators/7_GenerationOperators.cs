using System;
using Linq;
/*

Range, Empty, and DefaultIfEmpty

using csharp repl

*/

// RANGE  

var numbers = new List<int>();
for(int i = 0; i < 10; i++)
{
  numbers.Add(i);
}
numbers
//returns 0-9

var numbers = Enumerable.Range(0, 10); // starting number, how many times.
// returns the same
// only works with integers

// but we can start at ten and add ten 
var numbers = Enumerable.Range(10, 10);
// returns 10-19

// REPEAT
calling Enumerable.Repeat("LINQ is awesome!", 10);
// prints the string 10 times

// let's try it with birds
var blankBirds = Enumerable.Repeat(newBird(), 5);
blankBirds
// prints 5 blank birds

//EMPTY
var emptyBirds = Enumerable.Empty<Bird>();
//useful for instantiating a blank Enumerable. can't do:
// var emptyBirds = Enumerable();

//DEFAULTIFEMPTY
// will return at least one thing

var numbers = Enumerable.Empty<int>();
numbers
// { }
numbers.DefaultIfEmpty
// { 0 }

