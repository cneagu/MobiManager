var UserService = function () {

    this.ReadUserName = function (id, data, handleData) {
        ajaxService('User/LogIn/' + data, 'GET', '', handleData, '#singin');
    };

    this.Insert = function (data, handleData) {
        ajaxService('User/LogIn/Insert', 'POST', data, handleData, '#singin');
    };
};