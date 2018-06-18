var UserController = function (serviceContext) {
    var firstName = $('#new-username').focusout(function () {
        validationText($('#new-username').val(), '#new-username');
    });
    this.LogIn = function () {
        $('#logIn').on('click', function () {
            
        });
    };
};