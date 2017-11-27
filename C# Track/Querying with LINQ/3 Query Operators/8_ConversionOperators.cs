using System;
using Linq;
/*

ToList and ToArray

*/

birds.Where(b => b.Color == "Red").ToList();
// returns a list of birds with red as their color

var redBirds = birds.Where(b => b.Color == "Red");
// the above doesn't get immediately evaluated
// call ToList or another converstion operator iterates to produce the results

redBirds.ToList();
// same list

redBirds.ToArray();
// creates an array.


/*

end of class notes



*/