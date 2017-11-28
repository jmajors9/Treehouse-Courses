var quizQuestions = [
  ['What is the capital of Hunan, China?', 'CHANGSHA'],
  ['In what city is the Kentucky Derby held?', 'LOUISVILLE'],
  ['What was the last name of America\'s first president?', 'WASHINGTON']
];

var correctAnswers = 0;
var questions;
var answer;
var response;
var html;
var correctList = [];
var wrongList = [];


function print(message) {
  var outputDiv = document.getElementById('output');
  outputDiv.innerHTML = message;
}

function buildList (arr){
  var listHTML = '<ol>'
    for (var i = 0; i < arr.length; i += 1 ) {
      listHTML += '<li>' + arr[i] + '</li>';
    }
    listHTML += '</ol>';
    return listHTML;
}

for (var i = 0; i < quizQuestions.length; i +=1 ) {
  question = quizQuestions[i][0];
  answer = quizQuestions[i][1]
  response = prompt(question);
  response = response.toUpperCase();
  if (response === answer) {
      correctAnswers +=1;
      correctList.push(question);
    } else {
      wrongList.push(question);
    }
}

html = "You got " + correctAnswers + " question(s) right."
html += '<h2>You got these questions correct:</h2>';
html += buildList(correctList);
html += '<h2>You got these questions wrong:</h2>';
html += buildList(wrongList);
print(html);

/*********
if (response === answer) {
      print('Great job! You got ' + answer + ' correct! <br><br>')
    } else {
      print('Oops! The correct Answer was ' + answer + '. <br><br>');
    }
**********/