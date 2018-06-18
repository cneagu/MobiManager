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
        $('#logIn').on('click', function () {
            
        });
    };
};