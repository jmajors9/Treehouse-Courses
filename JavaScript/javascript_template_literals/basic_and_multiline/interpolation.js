let like = (thing) => `I like${thing}`;


const sentence = `<p>` + like(`apples`) + `.</p>`;

document.querySelector('.interpolation').innerHTML = sentence;
