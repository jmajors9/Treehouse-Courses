/* jshint esversion: 6*/

function like(thing) {
    return 'I like ' + thing;
}

function love(thing) {
    return `I love ${thing}`;
}

// const sentence = `<p>` + like('apples') + ', but ' + love('oranges') + `.</p>`;
const sentence = `<p> ${like('apples')}, but ${love('oranges')}.</p>`;

document.querySelector('.interpolation').innerHTML = sentence;
