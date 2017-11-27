birds.Take(3);
// gets the top 3

// now let's get the top three birds with the shortest name

birds.OrderBy(b => b.Name.Length).Take(3);
// getting the first three, ordered by name length
birds.OrderBy(b => b.Name.Length).Skip(3).Take(3);
//getting the second 3
birds.OrderBy(b => b.Name.Length).Skip(6).Take(3);
// only returns two, since there are only 8 birds

// TAKE WHILE
// will iterate through everything and as soon as it isn't satisfied, it stops
birds.TakeWhile(b => b.Name.Length < 6){}
birds.First()
//failed immediately because cardinal is 8 long

birds.OrderBy(b => b.Name.Length).TakeWhile(b => b.Name.Length < 6){}
// returns 3, because we ordered it the right way
// SkipWhile
birds.OrderBy(b => b.Name.Length).SkipeWhile(b => b.Name.Length < 6){}
