'use strict';

let str = 'There are x days until Halloween!';

let halloweenDate = new Date(new Date().getFullYear(), 9, 31);

let complexStr = str.replace('x', dayCount(new Date, halloweenDate));
// replacing "x" could obviously make for some problems if the above str was at all different.

console.log(complexStr);

function dayCount(start, end) {
	return Math.round((end - start)/(1000*60*60*24)); // (ms*sec*min*hr)
}
