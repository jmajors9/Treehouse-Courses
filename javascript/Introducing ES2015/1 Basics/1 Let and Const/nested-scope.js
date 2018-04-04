'use strict';

// (function () {
//   const student = { name: 'James' };
//   // two const for student! But it returns no exception.

//   function createStudent(name) {
//     const student = { name: name };
//     // but if you remove "const" in the above, it will throw an error. 
//     return student;
//   }
  
//   console.log(createStudent('Ken'));
//   console.log(student);
// })();

// (function () {
//   let student = { name: 'James' };
// // changed to let

//   function createStudent(name) {
//     student = { name: name }; // calling as declared above (don't use 'let' again)
//     return student;
//   }
//   // now we just get Ken twice.
//   console.log(createStudent('Ken'));
//   console.log(student);
// })();

let student = { name: 'James' };
// moving let outside of the func still returns Ken twice.

(function () {
  function createStudent(name) {
    student = { name: name };
    return student;
  }
  
  console.log(createStudent('Ken'));
  console.log(student);
})();

// USE LET when you need to reassign a variable, or scope a variable at the block level
// USE CONST when you don't want a variable's value to change throughout your project.
