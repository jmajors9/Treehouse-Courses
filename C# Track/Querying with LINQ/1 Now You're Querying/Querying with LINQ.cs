// Querying with LINQ
// using csharp repl

#region Video 2
using System.Linq;
// already included by default

List<int> numbers = new List<int> { 2, 4, 8, 16, 32, 64 };
// List Colleciton uses IEnumerable<T>
List<int> numbersGreaterThanTen = new List<int>();
foreach(int number in numbers)
{
  if (number > 10)
  {
    numbersGreaterThanTen.Add(number);
  }
}

numbersGreaterThanTen
//returns 
{16, 32, 64 }
// now we'll do it using LINQ
from number in numbers where number > 10 select number;
//returns 
{16, 32, 64 }
// and our original object was not modified
/*

"from number in numbers where number > 10 select number;"
range variable = from number 
source = in numbers
query = where number > 10
result = select number

*/

from n in numbers where n > 10 select n;
// returns
{16, 32, 64}

// some will break Linq queries into separate lines, for readability
from n in numbers 
where n > 10 
select n;
// same return

// it's returning ints, but is it what we want? let's assign to variable
List<int> numbersGreaterThanTen = from n in numbers
where n > 10
select n;
// got error cs0266
IEnumerable<int> numbersGreaterThanTen = from n in numbers
where n > 10
select n;
//ok now. 
numbersGreaterThanTen.Count()
#endregion

#region Code Challenge One

using System.Collections.Generic;
using System.Linq;

namespace Treehouse.CodeChallenges
{
  public class NumberAnalysis
  {
    private List<int> _numbers;
    public NumberAnalysis()
    {
      _numbers = new List<int> { 2, 4, 6, 8, 10 };
    }

    public IEnumerable<int> NumbersGreaterThanFive()
    {
      return _numbers.Where(n => n > 5); 
      // but we didn't go over this syntax...
    }    
  }
}


#endregion

#region Video 3

// obj initialization
public class Bird
{
  public string Name {get; set; }
  public string Color { get; set; }
  public int Sightings { get; set; }  
}
// let's initialize the list with some values
List<Bird> birds = new List<Bird>{
  new Bird { Name = "Cardinal", Color = "Red", Sightings = 3 },
  new Bird { Name = "Dove", Color = "White", Sightings = 2 }
}
// now birds = {Bird, Bird}

birds.Add(new Bird { Name = "Robin", Color = "Red", Sightings = 5 })
// now we have 3 birds
// same as 
Bird blueJay = new Bird();
blueJay.Name = "Blue Jay";
blueJay.Color = "Blue";
blueJay.Sightings = 1;
birds.Add(blueJay);

foreach(Bird bird in birds)
{
  Console.WriteLine(bird.Name);
}
// birds printed

#endregion

#region Challenge Two
Birds.cs
namespace Treehouse.CodeChallenges
{
    public class Bird
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Sightings { get; set; }
    }
}

// Refactor the LoadBirds method by using object initialization to add the pelican to the birds variable.

Bird Repository.cs
using System.Collections.Generic;

namespace Treehouse.CodeChallenges
{
    public static class BirdRepository
    {
        public static List<Bird> LoadBirds()
        {

          var birds = new List<Bird>() {
            new Bird { Name = "Pelican", Color = "White", Sightings = 3 }
          };
            // var pelican = new Bird();
            // pelican.Name = "Pelican";
            // pelican.Color = "White";
            // pelican.Sightings = 3;
            // birds.Add(pelican);
            return birds;
        }
    }
}
#endregion
