// problem: hints are shown while form is valid
// solution: have hints pop up at appropriate times
var $password = $("#password");
var $confirmPassword = $("#confirm_password");

// hide hint spans 
$("form span"). hide();

function isPasswordValid() {
	return $password.val().length > 8;
}

function arePasswordsMatching() {
	return $password.val() === $confirmPassword.val()
}

function canSubmit () {
	return isPasswordValid() && arePasswordsMatching();
}

function passwordEvent() {
	 if(isPasswordValid()) {
		$password.next().hide();
	} else {
		$password.next().show();
	}
}

function confirmPasswordEvent () {
	// find out if pw and conf match
	if(arePasswordsMatching()){
	// If matched, hide hint
		$confirmPassword.next().hide();
	} else {
		$confirmPassword.next().show();
	}
		// else show.

}

function enableSubmitEvent(argument) {
	$("#submit").prop("disabled", !canSubmit())
}
	
// When event happens on pw input
$password.focus(passwordEvent).keyup(passwordEvent).keyup(confirmPasswordEvent).keyup(enableSubmitEvent);

// When event happens on confirmation input
$confirmPassword.focus(confirmPasswordEvent).keyup(confirmPasswordEvent).keyup(enableSubmitEvent);



enableSubmitEvent();