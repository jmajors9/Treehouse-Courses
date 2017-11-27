/*
2_Sightings_of_Endangered_Birds.cs

Let's build a query to find out how many bird sightings we have for birds that are at risk of becoming endangered.
*/

var statuses = birds.Select(b => b.ConservationStatus).Distinct();
statuses
// list of statuses
statuses = statuses.Where(s => s!= "LeastConcern" && s !="NearThreatened");
statuses 
// "Endangered", "Vulnerable", CriticallyEndangered

// we can do a join, joining birds to status var and have a list of birds with the status
var endangeredSightings = birds.Join(statuses,
  b => b.ConservationStatus, 
  s => s,
  (b, s) => new {Status = s, Birds = b});

endangeredSightings
// got list of birds and status

// so now let's get sightings instead of the birds.
var endangeredSightings = birds.Join(statuses,
  b => b.ConservationStatus, 
  s => s,
  (b, s) => new {Status = s, Sightings = b.Sightings});
  // a lot of stuff...

// let's group by status
//cleared console
var endangeredSightings = birds.Join(statuses,
  b => b.ConservationStatus, 
  s => s,
  (b, s) => new {Status = s, Sightings = b.Sightings}).GroupBy(b => b.Status);

endangeredSightings
// statuses are there, it's grouped, but hard to make out

//clear console
// same query
var endangeredSightings = birds.Join(statuses,
  b => b.ConservationStatus, 
  s => s,
  (b, s) => new {Status = s, Sightings = b.Sightings}).GroupBy(b => b.Status).Select(b => new {Status = b.Key, Sightings = b.Sum(s => s.Sightings.Count())});

endangeredSightings
// returns the number of sightings per status entry