function validateEmail(email) {
    var result = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/;
    return result.test(email);
}

function changeBackground(color) {
    var element = document.getElementById('inputDiv');
    element.style.background = color;
}

function validateInput(){
    var input = document.getElementById('input').value.trim(),
        output = document.getElementById('inputDiv').innerHTML;

    output = input;
    document.getElementById('inputDiv').innerHTML = output;

    var isValidEmail = validateEmail(input);
    if (isValidEmail) {
        changeBackground('green');
    }
    else {
        changeBackground('red')
    }
}

