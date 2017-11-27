/*jshint esversion: 6 */
let like = (thing) => `I like ${thing}`;

let love = (thing) => `I love ${thing}`;

const sentence = `<p>${like(`apples`)}, but  ${love(`oranges`)}.</p>`;

document.querySelector('.interpolation').innerHTML = sentence;
