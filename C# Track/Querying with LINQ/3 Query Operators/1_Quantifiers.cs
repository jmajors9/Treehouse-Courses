// 1_Quantifiers.cs

// use any operator to check and see if any birds exist before adding one
birds.Any(b => b.Name == "Crow")
// returns true
if (!birds.Any(b => b.Name == "Crow"))
{
  birds.Add(new Bird {Name = "Crow"});
}

birds.Any();
//returns all birds

//CONTAINS

var sparrow = new Bird {Name = "Sparrow", Color = "Brown"};
if (!birds.Contains(sparrow))
{
  birds.Add(new Bird {Name = "Sparrow", Color = "Brown"});
}
birds
// should have a sparrow
// ALL

birds.All(b => b.Name != "Sparrow");
// returns false

// which is faster depends on how many objects are in the collection and how likely it is to pass or fail
// if it's more likely to prove true early on, use Any. otherwise, All