/*
var counter = 0;
while ( counter < 10 ) {
	document.write(counter);
	counter += 1;
}

for (var counter = 0; counter < 10; counter +=1 ) {
	document.write(counter);
}

*/

var html = '';

for ( var i = 1; i <= 10000; i += 1 ) {
	html += '<div>' + i + '</div>'
}

document.write(html);