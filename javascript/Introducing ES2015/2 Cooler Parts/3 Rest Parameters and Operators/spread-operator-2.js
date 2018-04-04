'use strict';

// split an array into a single arg

function myFunction (name, iceCreamFlavor) {
  console.log(`${name} really likes ${iceCreamFlavor} ice cream.`)
}

let args = ['Joel', 'Mint Choc Chip'];

myFunction(...args);
