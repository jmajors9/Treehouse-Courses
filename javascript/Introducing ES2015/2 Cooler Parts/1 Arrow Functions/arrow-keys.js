'use strict';

var Person = function (data) {
  for (var key in data) {
    this[key] = data[key];  
  }
  // this.getKeys = function () { // changing to arrow func below
  this.getKeys = () => { // now binds the func to Alena no matter where it's called.
    return Object.keys(this); // scope changed!, but better with arrow
  }
}

var Alena = new Person({ name: 'Alena', role: 'Teacher' });

console.log('Alena\'s Keys:', Alena.getKeys()); // 'this' refers to 'Alena'

var getKeys = Alena.getKeys;

console.log(getKeys()); // 'this' refers to the node process
