var UserService = function () {

    this.ReadUserName = function (id, data, handleData) {
        ajaxService('User/LogIn/' + data, 'GET', '', handleData, '#user_profile');
    };

    this.Insert = function (data, handleData) {
        ajaxService('User/LogIn/Insert', 'POST', data, handleData, '#user_profile');
    };

    this.ReadLogIn = function (data, handleData) {
        ajaxService('User/LogIn/ReadLogIn', 'POST', data, handleData, '#user_profile');
    };

    this.ReadById = function (data, handleData) {
        ajaxService('User/LogIn/ReadById/' + data, 'GET', '', handleData, '#user_profile');
    };

    this.Update = function (data, handleData) {
        ajaxService('User/LogIn/Update', 'POST', data, handleData, '#user_profile');
    };
    //read all

    this.ReadAll = function (data, handleData) {
        ajaxService('User/ReadAll', 'GET', '', handleData, '#user_profile');
    };

    //deviceUser
    this.DevicesList = function (data, handleData) {
        ajaxService('User/DevicesList', 'POST', data, handleData, '#user_profile');
    };
};