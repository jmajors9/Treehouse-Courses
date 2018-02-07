/* jshint esversion: 6 */
// There are three list items in the index.html file.
// We want to be able to enter a 0, 1 or 2 in the text field to embolden the list item with the corresponding index.
// Can you figure out what condition to put into the if statement to make this code work?

const laws = document.getElementsByTagName('li');
const indexText = document.getElementById('boldIndex');
const button = document.getElementById('embolden');

button.addEventListener('click', (e) => {
    const index = parseInt(indexText.value, 10);
  
    for (let i = 0; i < laws.length; i += 1) {
       let law = laws[i];
  
       // replace 'false' with a correct test condition on the line below
       if (i == index) {

           law.style.fontWeight = 'bold';
       } else {
           law.style.fontWeight = 'normal';
       }
    }
});
