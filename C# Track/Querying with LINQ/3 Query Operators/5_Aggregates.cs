// 5_Aggregates.cs

//  group birds by color like this

from b in birds
group b by b.Color

// method syntax

birds.GroupBy( b -> b.Color);

//we'll use the groupby method while looking at Aggregates
// analysis ops on data sets

birds.GroupBy(b => b.Color).Select(g => new { Color = g.Key, Count = g.Count() });
// result is bird counts for each color.

//SUM
birds.Sum(b => b.Sightings); 
//returns 32
//sum of sightings in each color group

birds.GroupBy(b => b.Color).Select(g=> new { Color = g.Key, Sightings = g.Sum(b => b.Sightings)});

birds.Average(b => b.Sightings);
birds.Min(b => b.Sightings);
birds.Max(b => b.Sightings);

// also check out LongCount and Aggregate

#region Code Challenge 
// carries on from previous codechallenge
var myBirds = new List<Bird> 
{ 
    new Bird { Name = "Cardinal", Color = "Red", Sightings = 3 },
    new Bird { Name =  "Dove", Color = "White", Sightings = 2 },
    new Bird { Name =  "Robin", Color = "Red", Sightings = 5 }
};

var yourBirds = new List<Bird> 
{ 
    new Bird { Name =  "Dove", Color = "White", Sightings = 2 },
    new Bird { Name =  "Robin", Color = "Red", Sightings = 5 },
    new Bird { Name =  "Canary", Color = "Yellow", Sightings = 0 }
};

var ourBirds = myBirds.Join(yourBirds,
                            mb => mb.Name,
                            yb => yb.Name,
                            (mb, yb) => (mb));

var sumOfSightings
var averageSightings


#endregion