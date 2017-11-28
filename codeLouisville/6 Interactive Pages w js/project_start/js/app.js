// Problem: User interaction doesn't effect desired results
// Solution: add interactivity so user can manage daily tasks.

var taskInput = document.getElementById("new-task"); //new-task
var addButton = document.getElementsByTagName("button")[0] //first button
var incompleteTasksHolder = document.getElementById("incomplete-tasks");
var completedTasksHolder = document.getElementById("completed-tasks");

// new Taks List Item
var createNewTaskElement = function (taskString) {
	// create List Item
	var listItem = document.createElement("li");

	// input {checkbox}
	var checkBox = document.createElement("input"); 
		// input {text}
		// label
		// button.edit
		// button.delete
	var label = document.createElement("label"); 
	var editInput = document.createElement("input"); 
	var editButton = document.createElement("button"); 
	var deleteButton = document.createElement("button"); 
			
	// each element needs modifying
	checkBox.type = "checkbox";
	editInput.type = "text";

	editButton.innerText = "Edit";
	editButton.className = "edit";
	deleteButton.innerText = "Delete";
	deleteButton.className = "delete";

	label.innerText = taskString;

	// each element needs appending
	listItem.appendChild(checkBox);
	listItem.appendChild(label);
	listItem.appendChild(editInput);
	listItem.appendChild(editButton);
	listItem.appendChild(deleteButton);

	return listItem;
}

// add tasks
var addTask = function() {
	console.log("Add task...");
	// create new list item with text from #new-task
	var listItem = createNewTaskElement(taskInput.value);
if(taskInput.value === ""){
	console.log("nothing to see here");
} else {
	// append listItem to incompleteTasksHolder
	incompleteTasksHolder.appendChild(listItem);
	bindTaskEvents(listItem, taskCompleted);}

	taskInput.value = "";
}
// edit tasks
var editTask = function() {
	console.log("Edit task...");
	
	var listItem = this.parentNode;
	var editButton = listItem.querySelector("button[class=edit]")
	var editInput = listItem.querySelector("input[type=text]");
	var label = listItem.querySelector("label");
	var containsClass = listItem.classList.contains("editMode");
	
		// if class of parent is .editMode
	if(containsClass){
		// switch from .editMode
		// label text become input's value
		editButton.innerText = "Edit"
		label.innerText = editInput.value;
	} else {
		// switch to .editMode
		// input value becomes the label's text
		editInput.value = label.innerText;
		editButton.innerText = "Save"
	}
		
		// Toggle .editMode on the listItem
		listItem.classList.toggle("editMode");
		
}
// delete tasks
var deleteTask = function() {
	console.log("Delete task...");
	var listItem = this.parentNode;
	var ul = listItem.parentNode;
	// remove parent list item from the ul
	ul.removeChild(listItem);
}
// mark completed tasks
var taskCompleted = function() {
	console.log("Complete task...");
	// append task list item to the #completed-tasks
	var listItem = this.parentNode
	completedTasksHolder.appendChild(listItem);
	bindTaskEvents(listItem, taskIncomplete);

}

// mark incomplete tasks
var taskIncomplete = function() {
	console.log("Incompleted task...");
// when checkbox unchecked
		// append task list item to the #incomplete-tasks
	var listItem = this.parentNode
	incompleteTasksHolder.appendChild(listItem);
	bindTaskEvents(listItem, taskCompleted);

}

var bindTaskEvents = function(taskListItem, checkBoxEventHandler){
	console.log("Bind list item events");
	// select children
	var checkBox = taskListItem.querySelector("input[type=checkbox]");
	var editButton = taskListItem.querySelector("button.edit");
	var deleteButton = taskListItem.querySelector("button.delete");
		// bind	editTask to edit button
		editButton.onclick = editTask
		// bind deleteTask to delete button.
		deleteButton.onclick = deleteTask
		// bind taskCompleted to checkbox
		checkBox.onchange = checkBoxEventHandler
		
		
}

// var ajaxRequest = function() {
// 	console.log("AJAX request");
// }
// addButton.onclick = ajaxRequest;


// Set the click handler to the addTask function
addButton.addEventListener("click", addTask)
// addButton.addEventListener("click", ajaxRequest)

// cycle over incompleteTasksHolder ul list items
for (var i = 0; i < incompleteTasksHolder.children.length; i++) {
	// bind events to list item's children (taskCompleted)
	bindTaskEvents(incompleteTasksHolder.children[i], taskCompleted);
}


// cycle over completedTasksHolder ul list items
for (var i = 0; i < completedTasksHolder.children.length; i++) {
	// bind events to list item's children (taskIncomplete)
	bindTaskEvents(completedTasksHolder.children[i], taskIncomplete);
}
		







