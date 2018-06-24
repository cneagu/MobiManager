var DeviceAssignationService = function () {

    this.SetUser = function (data, handleData) {
        ajaxService('DeviceAssignation/SetUser', 'POST', data ,handleData, '#user_profile');
    };
    this.RemoveUser = function (data, handleData) {
        ajaxService('DeviceAssignation/RemoveUser' + data, 'PUT', data, handleData, '#user_profile');
    };

    this.GetFreeDevice = function (data, handleData) {
        ajaxService('DeviceAssignation/GetFreeDevice', 'GET', '', handleData, '#user_profile');
    };

    this.ReadByID = function (data, handleData) {
        ajaxService('DeviceAssignation/ReadByID/' + data, 'GET', '', handleData, '#user_profile');
    };
};