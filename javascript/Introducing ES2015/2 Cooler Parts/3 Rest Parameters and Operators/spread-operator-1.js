'use strict';

// expands args

const originalFlavors = ['Chocolate', 'Vanilla'];

const newFlavors = ['Strawberry', 'Mint Chocolate Chip'];

// instead of using a combine, we're passing these as spreads into the middle of the array.
const inventory = ['Rocky Road', ...originalFlavors, 'Neopolitan', ...newFlavors];

// all of the values are added to the Array, not arrays added to the array

console.log(inventory);
