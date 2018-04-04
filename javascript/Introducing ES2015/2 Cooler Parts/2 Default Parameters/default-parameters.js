'use strict';

function greet(name = 'Joel', timeOfDay = 'Day') {
  // another way to set default params
    // function greet(name = 'Joel', timeOfDay = 'Day') {
  // one way to det some default params
    // name = name || 'Joel'; 
    // timeOfDay = timeOfDay || 'Day';  
  console.log(`Good ${timeOfDay}, ${name}!`);
}

greet(undefined, 'Afternoon'); // tells the interp to use default
