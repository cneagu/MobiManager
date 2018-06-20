var UserController = function (serviceContext) {
    var firstName = '';
    $('#new-firstName').focusout(function () {
        firstName = validationText($('#new-firstName').val(), '#new-firstName');
    });
    var lastName = '';
    $('#new-lastName').focusout(function () {
        lastName = validationText($('#new-lastName').val(), '#new-lastName');
    });
    var userName = '';
    $('#new-userName').focusout(function () {
        userName = validateUsername($('#new-userName').val(), '#new-userName');
    });
    var password = '';
    $('#new-password').focusout(function () {
        password = validatePassword($('#new-password').val(), '#new-password');
    });
    var cPassword = $('#new-c-password').focusout(function () {
        cPassword = validaterePassword($('#new-c-password').val(), password, '#new-c-password');
    });

    this.LogIn = function () {
        $('#singIn').on('click', function () {
            var role = dropdownValidate($('#new-role').val(), '#new-role');
            var location = dropdownValidate($('#new-location').val(), '#new-location');
            var terms = validateTerms($('#new-terms').is(':checked') ? 1 : 0);
            if (terms && cPassword !== null) {
                var userInput = {
                    FirstName: firstName,
                    LastName: lastName,
                    UserName: userName,
                    Password: password,
                    Role: role,
                    Location: location
                };
                if (validate(userInput) == 1) {
                    function responseNewUser(data) {
                        alert('New account created!   now you can login :)');
                        window.location.hash = '#home';
                    }

                    function checkteUserData(userName) {
                        if (userName) {
                            if (userName == userInput.UserName)
                                alert('This UserName already exists ' + 'UserName : ' + userName + ' ');
                        } else {
                            serviceContext.UserService().Insert(userInput, responseNewUser)
                        }

                    }
                    serviceContext.UserService().ReadUserName('#singin', userInput.UserName, checkteUserData);
                }
            }
        });
    };
};