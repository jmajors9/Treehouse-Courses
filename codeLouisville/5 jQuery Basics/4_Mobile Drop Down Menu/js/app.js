// problem: poor menu in smaller width environments
// solution: hide text links, swap out with a more appropriate nav

// create a select and append to menu
var $select = $("<select></select>");
$("#menu").append($select);

// cycle over menu links	
$("#menu a").each (function () {
	var $anchor = $(this);
	// create select options, value
	var $option = $("<option></option>");
	// deal with selected options depending on current page.
	if ($anchor.parent().hasClass("selected")) {
		$option.prop("selected", true)
	}
	// options value is the href
	$option.val($anchor.attr("href"));
	// opt's text is the text of links
	$option.text($anchor.text());
	// append opt to select
	$select.append($option);
});	
// create button 

$select.change(function () {
	// to select's location
	window.location = $select.val();
});


