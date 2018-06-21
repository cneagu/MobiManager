var DeviceService = function () {

    this.ReadByID = function (id, handleData) {
        ajaxService('Device/ReadByID/' + id, 'GET', '', handleData, '#user_profile');
    };
};