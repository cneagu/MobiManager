var UserService = function () {

    this.ReadUserName = function (id, data, handleData) {
        ajaxService('User/LogIn/' + data, 'GET', '', handleData, '#singin');
    };

    this.Insert = function (data, handleData) {
        ajaxService('User/LogIn/Insert', 'POST', data, handleData, '#singin');
    };

    this.ReadLogIn = function (data, handleData) {
        ajaxService('User/LogIn/ReadLogIn', 'POST', data, handleData, '#singin');
    };

    this.ReadById = function (data, handleData) {
        ajaxService('User/LogIn/ReadById/' + data, 'GET', '', handleData, '#singin');
    };

    this.Update = function (data, handleData) {
        ajaxService('User/LogIn/Update', 'POST', data, handleData, '#singin');
    };
    //read all

    this.ReadAll = function (data, handleData) {
        ajaxService('User/ReadAll', 'GET', '', handleData, '#singin');
    };

    //deviceUser
    this.DevicesList = function (data, handleData) {
        ajaxService('User/DevicesList', 'POST', data, handleData, '#singin');
    };
};