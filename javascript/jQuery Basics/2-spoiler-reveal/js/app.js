// create reveal spoiler button
const $button = $('<button>Reveal Spoiler</button>');
// append to web page
$('.spoiler').append($button);
// $('.spoiler').prepend($button);


// hide spoiler on page load
$('.spoiler span').hide();


// when button pressed
$('.spoiler button').click(function(){
  // show spoiler
  $('.spoiler span').show();
  // hide button 
  $('.spoiler button').hide();
});
