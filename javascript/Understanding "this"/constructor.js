var City = function(name, state) {
  this.name = name || 'Louisville';
  // default is Portland if not defined
  this.state = state || 'Kentucky';
  this.printMyCityAndState = function() {
    console.log("My city is " + this.name + ", and my state is " + this.state);
  };
};

ville = new City();
seattle = new City('Seattle', 'Washington');
lexington = new City('Lexington');
vancouver = new City('Vancouver', 'Washington');

ville.printMyCityAndState();
seattle.printMyCityAndState();
lexington.printMyCityAndState();
vancouver.printMyCityAndState();
