function ValidateForm(event) {
   // debugger;
    //validate e-mail
    var isFormValidated=false;
    event.preventDefault();
    var Email = document.getElementById("txtEmail").value;
    if (Email) {
        isFormValidated=true;
        document.getElementById("emailErrorMessage").innerHTML = "";
    }
    else {
        isFormValidated=false;
        document.getElementById("emailErrorMessage").innerHTML = "Please enter your e-mail.";
        return false;
    }

    //validate password with confirm password
	
	var Password = document.getElementById("txtPassword").value;
    if (Password) {
        isFormValidated=true;
        document.getElementById("passwordErrorMessage").innerHTML = "";
    }
    else {
        isFormValidated=false;
        document.getElementById("passwordErrorMessage").innerHTML = "Please enter your Password.";
        return false;
    }
	
	var CnfPassword = document.getElementById("txtConfirmPassword").value;
    if (CnfPassword) {
		if(CnfPassword===Password){
            isFormValidated=true;
        document.getElementById("cfmPasswordErrorMessage").innerHTML = "";
        document.getElementById("cfmPasswordErrorMessage").className = "msg-color-success";
		}
		else{
            isFormValidated=false;
		  document.getElementById("cfmPasswordErrorMessage").innerHTML = "password and confirm password doen't match.";
          return false;
        }
    }
    else {
        isFormValidated=false;
        document.getElementById("cfmPasswordErrorMessage").innerHTML = "Please enter confirm password.";
        return false;
    }
	
	
	var MobileNumber = document.getElementById("txtMobileNumber").value;
    if (MobileNumber) {
        const regexexp=new RegExp("^[0-9]{10}$");
        if(MobileNumber.match(regexexp))
        {
            isFormValidated=true;
            document.getElementById("MobileErrorMessage").innerHTML = "correct Number";
            document.getElementById("MobileErrorMessage").className = "msg-color-success";
        }
       else{
        isFormValidated=false;
        document.getElementById("MobileErrorMessage").innerHTML = "Please enter a valid Mobile Number.";
        return false;
    }
    }
    else {
        isFormValidated=false;
        document.getElementById("MobileErrorMessage").innerHTML = "Please enter your Mobile Number.";
        return false;
    }

    var radioButtons=document.getElementsByName('gender');
    var selectedRadioButtonVal="";
    for(i=0;i<radioButtons.length;i++){
        if(radioButtons[i].checked)
        {
            selectedRadioButtonVal=radioButtons[i].value;
        }
    }
    if (selectedRadioButtonVal) {
        isFormValidated=true;
        document.getElementById("radioErrorMessage").innerHTML = "";
    }
    else {
        isFormValidated=false;
        document.getElementById("radioErrorMessage").innerHTML = "Please enter your gender.";
        return false;
    }

    //const form=document.getElementsByClassName("frmRegister")[0];
    //console.log(event.target);
    //const data=new FormData(event.target);
    if(isFormValidated){
        var obj={
            "email":Email,
            "mobileNumber":MobileNumber,
            "password":Password,
            "gender":selectedRadioButtonVal
        }
        console.log(obj)
        localStorage["registerData"]=JSON.stringify(obj);
        localStorage["isLogin"]=true;
        window.location="dashboard.htm";
    }
    else{
        return false;
    }
   
}

function checkpassword(){
    var Password = document.getElementById("txtPassword").value;
	var CnfPassword = document.getElementById("txtConfirmPassword").value;
    if (CnfPassword) {
		if(CnfPassword===Password){
		
        document.getElementById("cfmPasswordErrorMessage").innerHTML = "password matches";
        document.getElementById("cfmPasswordErrorMessage").className = "msg-color-success";
		}
		else{
		  document.getElementById("cfmPasswordErrorMessage").innerHTML = "password and confirm password doen't match.";
		}
    }
    else {
        document.getElementById("cfmPasswordErrorMessage").innerHTML = "Please enter confirm password.";
    }
}