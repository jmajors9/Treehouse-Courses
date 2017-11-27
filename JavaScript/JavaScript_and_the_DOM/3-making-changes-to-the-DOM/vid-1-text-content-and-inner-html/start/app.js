/* jshint esversion: 6 */
const input = document.querySelector('input');
const p = document.querySelector('p.description');
const button = document.querySelector('button');

button.addEventListener('click', () => {
  p.textContent = input.value + ':';
  // or p.innerHTML = input.value + ':';
});

// if you want to get or set an elements class, class property won't work. use the class name instead.