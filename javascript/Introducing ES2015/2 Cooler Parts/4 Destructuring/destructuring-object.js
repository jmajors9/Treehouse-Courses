'use strict';

// one of the most useful features in 2015

let toybox = { item1: 'car', item2: 'ball', item3: 'frisbee' };

// let {item1, item2} = toybox; 

// console.log(item1); works
// console.log(item1, item2); works
// console.log(item1, item2, item3); // throws an error since it isn't defined in the toybox

// now try
let {item3: disc} = toybox;

console.log(disc);
