'use strict';

// collects the args passed to a function
// params is not the only thing.
// rest param has to be last

function myFunction(name, ...params) {
  console.log(name, params);
  // console.log(params); // params only
}

myFunction('joel', 1,2,3, 4, 'Jen');

// returned an array for the other things.

// if you run params only, it will make an array of all args
