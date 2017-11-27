 /* jshint esversion: 6 */
/*
function say(something) {
 console.log(something);
}
// now we have a way to say something on the console
*/

function exec(func, arg) {
  func(arg);
}

/*
// now we can accept a function and an argument
exec(say, 'Hi there');
// called on say, gave the argument 'Hi there'
*/

// we can pass a function into a function, too
/*
exec(function say(something) {
 console.log(something);
}, 'Hi there');
*/

// call it a different way:

exec((something) => {
 console.log(something);
}, 'Hi there func');

