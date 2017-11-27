/*
Extension methods
Where(TSource) Method
(IEnumberable<TSource>, Func<TSource, Boolean>)

predicate tests for true or false. where method needs a false

*/
// using csharp REPL

from b in birds
where b.Color == "Red"
select b;
// now with a lambda expression
birds.Where((b) => b.Color == "Red");
// diff
birds.Where( (b) => {return b.Color == "Red";});
//diff
birds.Where( b => b.Color == "Red");


from b in birds
orderby b.Color
select b;
// now using method syntax
birds.OrderBy(b => b.Color);

birds.OrderByDescending(b => b.Color);

// what if we need to order and filter at the same time?
// METHOD CHAINING
birds.Where(b => b.Color == "Red").OrderBy(b => b.Name);

//THENBY
birds.OrderBy(b => b.Name).ThenBy(b => b.Sightings);
//calling order by twice
birds.OrderBy(b => b.Name).OrderBy(b => b.Sightings);
// end up with the entire collection sorted by sightings

birds.Select(b => new { b.Name, b.Color});
// creating new collection from retrieved values.