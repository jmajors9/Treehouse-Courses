/*

3_Bird_Importing.cs

Let's use LINQ to help us identify what birds are new to our data set before we import them.

*/

var importedBirds = BirdRepository.LoadImportedBirds();
importedBirds
// returns list
 var birds = BirdRepository.LoadBirds();
 // imported birds list has some that aren't in the reg list. let's use a join to find the ones that aren't duplicated

 var newBirds = importedbirds.Join(birds,
  ib => ib.CommonName,
  b => b.CommonName,
  (ib, b)=> new {ImportedBirds = ib, Birds = b});
 // this will give us the birds that are already in our data.

 // LET'S USE AN OUTER JOIN
 // the Join we used earlier is called an InnerJoin
   // compares two sequences and returns only the elements where the property values are equal in both sets.
 //OUTER JOIN
  // compares two as well, returns all the elements from one sequence and only the matching elements from the other sequence
  // there are more options out there

//LeftJoin
 var newBirds = importedbirds.GroupJoin(birds,
  ib => ib.CommonName,
  b => b.CommonName,
  (ib, b) => new {ImportedBirds = ib, Birds = b});

// returns an enumerable of imported birds, then a bunch of empty groupings (our new birds)

 // need to flatten out our groupings
 // also use defaultifempty. need a null

var newBirds = importedbirds.GroupJoin(birds,
  ib => ib.CommonName,
  b => b.CommonName,
  (ib, b) => new { ImportedBird = ib, Birds = b}).SelectMany(gb => gb.Birds.DefaultIfEmpty), // note ImportedBird is singular
  (gb, b) => new { ImportedBird = gb.ImportedBird, Bird = b});
   
// returns a flat list with an imported bird and a matching bird as null if no match

// we only care about the birds that didn't have a match. let's add a where clause.
newBirds.Where(nb => nb.Bird == null)
// returns only imported birds we need. 

// let's get rid of the bird object that's null
newBirds.Where(nb => nb.Bird == null).Select(nb => nb.ImportedBird)
// returns nice, clean list of { Name: Ibadan Malimbe, Name: etc... }

// let's assign these to a variable 
var newImportedBirds = newBirds.Where(nb => nb.Bird == null).Select(nb => nb.ImportedBird).ToList();
// now it's ready to import into our birds list
// let's use add range to add them all at once.
birds.AddRange(newImportedBirds);
birds.Count()
// 209