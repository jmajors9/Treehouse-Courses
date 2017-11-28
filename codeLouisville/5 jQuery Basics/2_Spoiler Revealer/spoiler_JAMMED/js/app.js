// Prevent spoiler-phobes from seeing spoilers.
// Solutino: Hide spoilers, reveal through user interaction.

// 1. Hide spoiler 
$(".spoiler span").hide();

// 2. Add a button
$(".spoiler").append("<button>Reveal Spoiler!</button>");
// 3. when Button is pressed
$("button").click(function(){
	// 3.1. this shows the spoiler next to the button clicked

	$(this).prev().show();
	// 3.2. Get rid of button
	$(this).remove();
});
	
