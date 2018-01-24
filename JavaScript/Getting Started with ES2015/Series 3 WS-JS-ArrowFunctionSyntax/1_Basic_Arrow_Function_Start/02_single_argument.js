/* jshint esversion: 6 */
// function square(x) {
//     return x * x;
// }

// function cube(x) {
//     return square(x) * x;
// }

// const square = (x) => {
//     return x * x;
// }

// const cube = (x) => {
//     return square(x) * x;
// }

/* even more concise
single args don't need ()
one line doesn't need return
don't even need the braces
*/
const square = x => x * x;

const cube = x => square(x) * x;
