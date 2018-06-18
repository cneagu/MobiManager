var UserService = function () {

    this.ReadUserName = function (id, data, handleData) {
        ajaxService('User/LogIn/' + data, 'GET', '', handleData, '#singin');
    };
};