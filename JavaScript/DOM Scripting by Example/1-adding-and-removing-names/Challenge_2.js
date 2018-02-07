/* jshint esversion: 6 */

// The div with the ID colorDiv should change red when the red button is clicked, and blue when the blue button is clicked. Currently, though, only the red button is working. Can you figure out how to alter the javascript code without adding any lines to the blue button's event handler?

// Make sure a reference to colorDiv is held in a constant named colorSquare.

const redButton = document.getElementById('redButton');
const blueButton = document.getElementById('blueButton');
const colorSquare = document.getElementById('colorDiv');

redButton.addEventListener('click', (e) => {
  // const colorSquare = document.getElementById('colorDiv');
  colorSquare.style.backgroundColor = 'red';
});

blueButton.addEventListener('click', (e) => {
  colorSquare.style.backgroundColor = 'blue';
});
