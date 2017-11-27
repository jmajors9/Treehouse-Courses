/* jshint esversion: 6 */

/*

const myHeading = document.getElementsByTagName('h1')[0];
const myButton = document.getElementById('myButton');
const myTextInput = document.getElementById('myTextInput');

// what about an element that doesn't have an id?
// const myParagraph = document.getElementsByTagName('p');
// but notice that this has ElementS, not element

myButton.addEventListener('click', () => {
  myHeading.style.color = myTextInput.value;
}); 

*/

const myList = document.getElementsByTagName('li');

// myList[2].style.color = 'purple'

for (let i = 0; i < myList.length; i += 1) {
  myList[i].style.color = 'purple'; 
}