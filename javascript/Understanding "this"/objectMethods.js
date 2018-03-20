var Portland = {
  bridges: 12,
  airport: 1,
  soccerTeams: 1,
  logNumberOfBridges: function() {
    console.log("There are " + this.bridges + " bridges in Portland!")
  },
  
}

function logTeams () {
  console.log(this.soccerTeams)
}

Portland.foo = logTeams;

Portland.logNumberOfBridges();
Portland.foo();
logTeams(); // comes back undefined. there's no 

// this. whatever is looking up the value bridges within Portland
