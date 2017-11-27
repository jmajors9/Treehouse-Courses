/* jshint esversion: 6 */
const myList = document.getElementsByTagName('li');

for (let i = 0; i < myList.length; i += 1) {
  myList[i].style.color = 'purple';
}

const errorNotPurple = document.querySelectorAll('.error-not-purple');

for (let i = 0; i < errorNotPurple.length; i += 1) {
  errorNotPurple[i].style.color = 'red';
}

const odds = document.querySelectorAll('li:nth-child(odd)');

for (let i = 0; i < odds.length; i += 1) {
  odds[i].style.backgroundColor = 'lightgray';
}

/*
const querySelectorAll = document.querySelectorAll('li');
// will return full section
const querySelector = document.querySelector('li');
// will return first
const titleQuery = document.querySelector('[title=label]');
*/
