var DeviceAssignationService = function () {

    this.SetUser = function (data, handleData) {
        ajaxService('DeviceAssignation/SetUser', 'POST', data ,handleData, '#user_profile');
    };
    this.RemoveUser = function (data, handleData) {
        ajaxService('DeviceAssignation/RemoveUser', 'POST', data, handleData, '#singin');
    };

    this.GetFreeDevice = function (data, handleData) {
        ajaxService('DeviceAssignation/GetFreeDevice', 'GET', '', handleData, '#singin');
    };

    this.ReadByID = function (data, handleData) {
        ajaxService('DeviceAssignation/ReadByID/' + id, 'GET', '', handleData, '#singin');
    };
};