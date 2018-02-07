// Challenge Task 1 of 2
// Alter the event handler on line 4 to run when the form is submitted, not just when the submit button has been clicked. Leave the callback function empty for now.

// const form = document.querySelector('form');
// const submitButton = form.querySelector('[type=Submit]');

// form.addEventListener('submit', () => {
  
// });

// Challenge Task 2 of 2
// Alter the callback function to use the event object. Using the event object, ensure that the browser's default form submit behavior does not occur when the form is submitted.

const form = document.querySelector('form');
const submitButton = form.querySelector('[type=Submit]');

form.addEventListener('submit', (e) => {
  e.preventDefault();
});
