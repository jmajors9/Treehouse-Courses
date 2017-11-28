var person = {
  name : 'Sarah',
  country : 'US',
  age : 35,
  treehouseStudent : true,
  skills : ['JavaScript', 'HTML', 'CSS']
};

function print(message) {
  var div = document.getElementById('output');
  div.innerHTML = message;
}

var message = '<p>Hello. My name is ' + person.name + '.</p>';
message += '<p>I live in the ' + person.country + '.</p>';
person.name = 'Randbow Dash';
message += '<p>But I wish my name was ' + person.name + '.</p>';
/*
person.car = 'BMW';
message += '<p>I also wish my car was a  ' + person.car + '.</p>'
*/
person.age +=1
message += '<p>My age is now ' + person.age + '.</p>';
message +=  '<p>I have ' + person.skills.length + ' skills. ';
message += 'They are: ' + person.skills.join(', ') + '.</p>';
print(message);