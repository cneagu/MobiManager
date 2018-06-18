var UserController = function (serviceContext) {
    this.LogIn = function () {
        $('#logIn').on('click', function () {
            var firstName = $('#new-username').focusout(Function(){
                console.log('success');
            });
        });
    };
};