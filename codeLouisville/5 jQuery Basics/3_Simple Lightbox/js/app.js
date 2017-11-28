// Problem: User clicks image, goes to dead end.
// Solution: create overlay with larger image

var $overlay = $('<div id="overlay"></div>');
var $image = $("<img>");
var $caption = $("<p></p>")
// add image to overlay
$overlay.append($image);

//a caption
$overlay.append($caption);

// create overlay
$("body").append($overlay);




// 1. capture click event on an image link
$("#imageGallery a").click(function (event) {
	event.preventDefault();
	var imageLocation = $(this).attr("href");
	// update overlay with image clicked
	$image.attr("src", imageLocation);
	// 1.1 show overlay
	$overlay.fadeIn();
	// Get child's alt-atribute and set caption
	var captionText = $(this).children("img").attr("alt");
	$caption.text(captionText);
});

// 3. hide the overlay on click
$overlay.click(function () {
	$overlay.fadeOut();
	// body...
});