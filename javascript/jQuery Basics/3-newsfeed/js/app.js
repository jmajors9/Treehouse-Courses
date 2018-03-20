const $odd = $('a:odd');
// $odd.hide(); // automatically loops. returns a collection of jquery objects
const $secureLinks = $('a[href^="https://"]');
const $pdfs = $('a[href$="pdf"]');
const $pdfCheckbox = $('<label><input type="checkbox"> Allow PDF downloads</label>')

$secureLinks.attr('target', '_blank');
$pdfs.attr('download', true);

$secureLinks.addClass('secure');
$pdfs.addClass('pdf');

$pdfs.on('click', function(event) {
  if ($(':checked').length === 0) {
    event.preventDefault();
    alert('Please check the box to allow PDF downloads.');
  }
});

$('#links').append($pdfCheckbox);

// $('a').each(function(index, link) {
//   const url = $(link).attr('href');
//   $(link).parent().append(`(${url})`); // backticks for string interpolation
// });

// shorter method
$('a').each(function() {
  const url = $(this).attr('href');
  $(this).parent().append(`(${url})`);
});
