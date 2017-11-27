#region Selecting, Projecting, and Anonymous Types

 csharp repl stuff
var canary = new Bird { Name = "Canary", Color = "yellow", Sightings = 0};
// type inferred from right side

birds.Add(canary);

foreach(var bird in birds)
{
  Console.WriteLine(bird.Name);
}
//results Cardinal through canary

// let's write a query to get all birds that are red
 from b in birds 
 where b.Color == "Red"
 select b;
 // returns the bird obj
 // let's get just the names
 from b in birds 
 where b.Color == "Red"
 select b.Name;
 // returns Enumerable of Bird Names

 from b in birds 
 where b.Color == "Red"
 select new {b.Name, b.Color};
 // sending the results of the Linq query to the anonymouse type
 // like creating new type on the fly
 // doesn't have a name
 // can specify diff property names if we want.

from b in birds
where b.Color == "Red"
select new {BirdName = b.Name, BirdColor = b.Color };
/*
result
{{BirdName = Cardinal, BirdColor = Red}, {BirdName = Robin, BirdColor = Red } }
*/
// can create anonymouse type obj using var keyword
var anonymousPidgeon = new { Name = "Pidgeon", Color = "White", Sightings = 10 };
//have to use var keyword 
var anonymousCrow = new { Name = "Crow", Color = "Black", Sightings = 11 };
// it's ok
// calling anonymousCrow.GetType() ==  anonymousPidgeon.GetType()
// true
// to add, will still have to go the long way.
birds.Add(anonymousCrow); //doesn't work

birds.Add (new Bird{
  Name = anonymousCrow.Name,
  Color = anonymousCrow.Color,
  Sightings = anonymousCrow.Sightings
});
// can't really pass anon types without retro work
// only useful for holding data in a small scope
#endregion

#region Ordering and Grouping

//loading bird.cs stuff
from b in birds
orderby b.Name
select b.Name;
// returns bird names in alphabetical list

//to get a reversed list...
from b in birds
orderby b.Name descending
select b.Name;

// to order by mult properties, split up with a comma
from b in birds
orderby b.Color, b.Sightings descending
select b.Name;
// just gives us the name. let's get name and sightings.
from b in birds
orderby b.Color, b.Sightings descending
select new {b.Name, b.Sightings }

// GROUPING
// org a collecion by a common attribute
// group and into
// start with grouping by string... color
var birdsByColor = from b in birds
  group b by b.Color;
// no select clause what do we get when we call?
  System.Linq.GroupedEnumerable
// lets access the collection by key
foreach(var bird in birdsByColor)
{
  Console.WriteLine(bird.Key + " " + bird.Count());
}
//result
Red 2
White 2
Blue 1
Yellow 1
Black 1

// can also use into in a query
from b in birds
group b by b.Color into birdsByColor // new range variable
where birdsByColor.Count() > 1

select new { 
  Color = birdsByColor.Key, Count = birdsByColor.Count() 
};

//result 
{{Color = Red, Count = 2}, {Color = White, Count = 2}}

#endregion