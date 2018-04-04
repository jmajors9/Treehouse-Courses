 'use strict';

(function initLoop() {
  function doLoop(x) {
    console.log('loop:', x);
  }
  
  for (var i = 0; i < 10; i++) {
    doLoop(i + 1);
  }
})();

// so what could go wrong?
// should ex 10x and exit?

(function initLoop() {
  function doLoop(x) {
   i=3; // creates an infinite loop!
    console.log('loop:', x);
  }
  // "let" creates block level scoping so that i is not available outside of it. so now we'll comment out the i=3 above.
  for (let i = 0; i < 10; i++) { // adding let now throws the exception that i is not defined.
    doLoop(i + 1);
  }
})();

(function initLoop() {
  function doLoop(x) {
    console.log('loop:', x);
  }
  for (let i = 0; i < 10; i++) {
    doLoop(i + 1);
  }
})();
