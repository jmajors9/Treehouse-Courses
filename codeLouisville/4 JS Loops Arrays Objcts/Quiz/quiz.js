/*
1. ask five questions
2. keep track of the number of questions the user answered correctly
3. provide a message after the quiz
    number of questions right
 4. rank the player
  5 = gold
  3-4 = silver
  1-2 = bronze
  0 = LOSER
*/

//Questions
var questionOne =
  prompt("What number does one dial in America for emergencies?");
var questionTwo =
  prompt ('How many Senators are in the U.S. Senate?');
var questionThree =
  prompt ('How many States are in the United States of America?');
var questionFour =
  prompt ('How many branches of Parliament in the UK?');
var questionFive =
  prompt ('How many planets are there?');

//Correct Answer code
answerOne = (parseInt(questionOne) === 911)
answerTwo = (parseInt(questionTwo) === 100)
answerThree = (parseInt(questionThree) === 50)
answerFour = (parseInt(questionFour) === 3)
answerFive = (parseInt(questionFive) === 8)

var correctAnswers = (answerOne + answerTwo + answerThree + answerFour + answerFive)

// Crowns
if ( correctAnswers === 5 ) {
    document.write("Congratulations! You answered " + correctAnswers + " correctly! You get the Gold Crown!");
} else if ( correctAnswers >= 3 ) {
    document.write("Congratulations! You answered " + correctAnswers + " correctly! You get the Silver Crown!");
}
 else if ( correctAnswers >= 1 ) {
    document.write("Congratulations! You answered " + correctAnswers + " correctly! You get the Bronze Crown!");
 }
 else {
    document.write("<p>I'm sorry, you receive no crowns this time. Get on Google, find the answers and try again!</p>");
}
