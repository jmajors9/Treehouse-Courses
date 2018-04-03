function foo(argument) {
  console.log('foobar');
};

foo();

// the above is cluttering the global namespace
// so we'll wrap the code in a self executing anonymous func

(function() {
  function foo(argument) {
    console.log('foobar');
  };

  foo();
}());

// so we treat the whole thing as an expression evaled immediately and doesn't need naming or assignment

// or you can replace the closures with a bang or a plus
// this can save a lot of potential hazard with random parenthesis

!function() {
  function foo(argument) {
    console.log('foobar');
  };

  foo();
}();

// http://stackoverflow.com/questions/3755606/what-does-the-exclamation-mark-do-before-the-function



// now we rename the variable

!function(underscore) {
  underscore.someawesomemethod = "yay!!!";
}(_);

// so now JS doesn't look outside of the local instance for the vars


// MODULE EXPORT PATTER

var awesomeNewModule = (function () {
  var exports = {
    foo: 5,
    bar: 10
  }
  exports.helloMars = function() {
    console.log("Hello Mars!");
  };
  exports.goodbye = function() {
    console.log("Goodbye!")
  }

  return exports
}());

// one will rarely have different large code in one file.
// loose augmentation


var awesomeNewModule = (function(exports) { //adding exports makes the values assigned to an empty obj or get assigned and extend anw after the module is created.
  // the last file overwrites previous (CSS style), so be careful with exports and other values if you load something like anw earlier.
  // you cannot share values across modules. which makes sense. these are modules and should not be dependent.
  var exports = {
    foo: 5,
    bar: 10
  }
  exports.helloMars = function() {
    console.log("Hello Mars!");
  };
  exports.goodbye = function() {
    console.log("Goodbye!")
  }

  return exports
}( awesomeNewModule || {} )); // this imports ANW if it's there. otherwise makes an object

// SUB MODULE

var awesomeNewModule.sub = (function(exports) { // sub is adding safeguards to prevent overwriting
  var exports = {
    foo: 5,
    bar: 10
  }
  exports.helloMars = function() {
    console.log("Hello Mars!");
  }
  exports.goodbye = function() {
    console.log("Goodbye!")
  }
  return exports
}( awesomeNewModule.sub || {} )); // to import anw.sub or make an object

// looking at bootstrap repo on github. any js files

// https://github.com/airbnb/javascript/issues/44#issuecomment-13063933
// the pass in the "this" parameter in the local scope
// mode has a module keyword 

// github.com/airbnb/polygloy.js/blob/master/lib/polyglot.js
  // line 282
  if (typeof module !== 'undefined' && module.exports) {
    module.exports = Polyglot;
  } else {
    root.Polyglot = Polyglot;
  }
// the above evaluates if it is being run on the server (node.js), or if it's being run in the browser. then sends it the appropriate export.
