/********************************************
I'm absolutely sure that I am not doing this the way he would.
qAndA array.
add questions, answer0, answer1 to it.
pull from it for q's, answers
pull from the array for length, for how many they answered correctly.
*********************************************/



var quiz = new QuestionsAnswers();

var question0 = new QuestionsAnswers("What is your favorite color?", "blue", "no, Yellow!");
var question1 = new QuestionsAnswers("What is the airspeed velocity of an unladen swallow?", "40 km/h", "African or European?");



var guessButton0 = document.getElementById("guess0");
guessButton0.onclick = function() {
	this.qAndA.push(answer0)
}

var guessButton1 = document.getElementById("guess1");
guessButton1.onclick = function() {
	this.qAndA.push(answer1)
	// add something to the "Progress Bar"
}

var progressBar = document.getElementById("progress")


//Questions
function QuestionsAnswers(question, answer0, answer1) {
	this.qAndA = [];
}

QuestionsAnswers.prototype.renderInElement = function(list) {

}
var questionElement = document.getElementById("question");

QuestionsAnswers.prototype.toHTML = function() {
	var htmlString = '';
	
}


/********************************************
// Answers: id choice0 choice1
write out answers above the buttons based on the block of crap in QuestionsAnswers
*********************************************/



/********************************************
Scoring
somehow keep track

You got x out of y correct. again from the qAndA array.
*********************************************/



/********************************************
Progress Bar
do something about the correct answers block
progressbar
qAndA pull which 0 or 1 and +1 into the x. set "y" based on total in the array (qAndA.length)
*********************************************/


