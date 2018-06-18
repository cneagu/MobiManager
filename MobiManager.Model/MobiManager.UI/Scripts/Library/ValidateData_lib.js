function validateDigits(val, id) {
    if (!(/^[0-9]+$/i.test(val))) {
        $(id).addClass("is-invalid");
        val = '';
        return val;
    } else {
        $(id).removeClass("is-invalid");
        $(id).addClass("is-valid");
        return val;
    }
}

//function validateEmail(email, id) {
//    if (!(/^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$/i.test(email))) {
//        $(id).addClass("is-invalid");
//        email = '';
//        return email;
//    } else {
//        $(id).removeClass("is-invalid");
//        $(id).addClass("is-valid");
//        return email;
//    }
//}

function validateUsername(username, id) {
    if (!(/^[a-z][a-z0-9_.-]{4,19}$/i.test(username))) {
        $(id).addClass("is-invalid");
        username = '';
        return username;
    }
    else {
        $(id).removeClass("is-invalid");
        $(id).addClass("is-valid");
        return username;
    }
}

function validatePassword(password, id) {
    errors = [];
    if (password.length < 8) {
        errors.push("Your password must be at least 8 characters");
    }
    if (password.search(/[a-z]/i) < 0) {
        errors.push("Your password must contain at least one letter.");
    }
    if (password.search(/[0-9]/) < 0) {
        errors.push("Your password must contain at least one digit.");
    }
    if (errors.length > 0) {
        alert(errors.join("\n"));
        password = '';
        $(id).addClass("is-invalid");
        return password;
    }
    $(id).removeClass("is-invalid");
    $(id).addClass("is-valid");
    return password;
}

function validaterePassword(rePassword, password, id) {
    if (rePassword !== password || rePassword === '') {
        $(id).addClass("is-invalid");
        rePassword = '';
        return rePassword;
    } else {
        $(id).removeClass("is-invalid");
        $(id).addClass("is-valid");
        return rePassword;
    }
}

function dropdownValidate(item, id) {
    if (item === null) {
        $(id).addClass("is-invalid");
        alert("please select " + id.substring(5));
        return '';
    }
    $(id).removeClass("is-invalid");
    $(id).addClass("is-valid");
    return item;
}

function validateTerms(term) {
    if (term == 0)
        alert("Please read an check Terms and conditions");
    return term;
}

function validate(inputData) {
    for (var i in inputData) {
        if (inputData[i] == '' || inputData[i] == null || inputData[i] == 0) {
            alert(i + '  Is not Ok');
            return 0;
        }
    }
    return 1;
}

function validateDigit(nb) {
    if (isNaN(nb))
        return 0;
    return nb;
}
function validationText(text,id) {
    if (!(/^[A-Za-z]*$/i.test(text)) || text == '' || text == undefined) {
        $(id).addClass("is-invalid");
        text = '';
        return text;
    }
    else {
        $(id).removeClass("is-invalid");
        $(id).addClass("is-valid");
        return text;
    }
}

function validateCurentPassword(paswword) {
    if (CURENT_USER.Password == paswword)
        return paswword;
    return '';
}