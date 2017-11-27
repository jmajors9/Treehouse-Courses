/* 
1_How_Much_Data_Do_We_Have.cs

typing up the REPL work done in treehouse
*/

LoadAssembly("BirdWather.dll");
using BirdWatcher
var birds = BirdRepository.LoadBirds();

birds.Count()
// 201

birds.Select(b => b.Sightings).Count();
// 201
// only returned the number of the sightings collections

birds.SelectMany(b => b.Sightings).Count();
// 1817

// whats avg sighting count per bird?
// one method
birds.SelectMany(b => b.Sightings).Count() / birds.Count();
// 9

// better way
birds.Select(b => b.Sightings.Count()).Average();
// 9.0398... a little more accurate

// from how many countries do we have sighting data?
birds.SelectMany(b => b.Sightings).Select(s => s.Place.Country);
// list of country strings

// now let's get distinct country returns
birds.SelectMany(b => b.Sightings).Select(s => s.Place.Country).Distinct(); 
// much shorter list of strings

// now for how many sightings are in each country
// we will need to use a grouping
birds.SelectMany(b => b.Sightings).GroupBy(s => s.Place.Country); 
// gave us a bunch of sighting entries, but not country names
birds.SelectMany(b => b.Sightings).GroupBy(s => s.Place.Country).Select(grp => new { Country = grp.Key, Sightings = grp.Count()});
// returns s list like {Country = Canada, Sightings = 206}, { etc. }
