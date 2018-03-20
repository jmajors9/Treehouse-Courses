// event delegation. the listener is based on the parent
// adding event object e is for event
$('.spoiler').on('click', 'button', function(e){
  $(this).prev().show();
  // $(e.target).prev().show();
  // but this could cause a problem
  $(this).hide();  
  // $(e.target).hide();  
});

// create reveal spoiler button
const $button = $('<button>Reveal Spoiler</button>');

$('.spoiler').append($button);

// hide spoiler on page load
$('.spoiler span').hide();
