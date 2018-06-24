var DeviceService = function () {

    this.ReadByID = function (id, handleData) {
        ajaxService('Device/ReadByID/' + id, 'GET', '', handleData, '#user_profile');
    };

    this.Insert = function (data, handleData) {
        ajaxService('Device/Insert', 'POST', data, handleData, '#user_profile');
    };

    this.Update = function(data, handleData) {
        ajaxService('Device/Update', 'POST', data, handleData, '#user_profile');
    };

    this.Delete = function (data, handleData) {
        ajaxService('Device/Delete/' + data, 'DELETE', '', handleData, '#user_profile');
    };
};