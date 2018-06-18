var UserController = function (serviceContext) {
    var firstName = $('#new-firstName').focusout(function () {
        validationText($('#new-firstName').val(), '#new-firstName');
    });
    var lastName = $('#new-lastName').focusout(function () {
        validationText($('#new-lastName').val(), '#new-lastName');
    });
    var userName = $('#new-userName').focusout(function () {
        validateUsername($('#new-userName').val(), '#new-userName');
    });
    var password = $('#new-password').focusout(function () {
        validatePassword($('#new-password').val(), '#new-password');
    });

    this.LogIn = function () {
        $('#logIn').on('click', function () {
            
        });
    };
};