var colors = new List<string> {"Red", "Blue", "Purple"};
var favoriteBirds = from b in birds
join c in colors on b.Color equals c; //not "="
select b;

favoriteBirds
// retunrs cardinal, robin, bluejay

/* now with method syntax
    four keys to carry: 
      inner seq - joins the outer sequence
      key from outer - chooses what we'll pull from outer
      key from inner - chooses what we'll pull fom inner
      result from join
    they are all funcs

 */

var favoriteBirds = birds.Join(colors,
  b => b.Color, 
  c => c, //since it's just a string
  (bird, color) => bird);

favoriteBirds;
// cardinal, robin, bluejay

// try query again, diff result

var favoriteBirds = birds.Join(colors,
  b => b.Color,
  c => c,
  (bird, color) => new { Color = color, Bird = bird});

favoriteBirds
// returns an IEnumerable { {Color= Red, Bird = Name: Cardinal, Color: Red, Siginings: 3}, etc.}

//GROUPJOIN
// same syntax as regular join

// let's have the birds grouped by color

var groupedBirds = colors.GroupJoin(birds,
  c => c,
  b=> b.Color,
  (color, bird) => new {Color = color, Birds = bird}  );

//now we'll use the selector to choose only something
groupedBirds.Select(g => g.Color);
// returns only the colors of our grouped birds. Returns Purple, though we don't have purple
groupedBirds.Where( g=> g.Color == "Purple").Select(g => g.Birds);
//collection is empty
groupedBirds.SelectMany(g => g.Birds);
//returns list of grouped birds flattened into a collection


#region Joins Challenge
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

  var ourBirds = 
    myBirds.Join(yourBirds, 
    m => m.Name,
    y => y.Name,
    (bird, name) => bird);
    
#endregion