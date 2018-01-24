/* jshint esversion: 6 */
const name = "Andrew";

// declaration
// function sayName() {
//     const message = "My name is " + name;
//     console.log(message);
// }
 
//
// const sayName = function () {
//     const message = "My name is " + name;
//     console.log(message);
// }

// arrow based
// this one can't be reduced further with two lines of code. have to leave () because of no args.
const sayName = () => {
    const message = "My name is " + name;
    console.log(message);
}

const sayBye = () => console.log("Bye " + name);
