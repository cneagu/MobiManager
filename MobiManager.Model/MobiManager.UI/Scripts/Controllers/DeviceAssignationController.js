var DeviceAssignationController = function (serviceContext) {

    this.Assignation = function () {
        $('#assingDeviceModal').on('click', function () {
            //set user options
            $('#current-assign-UserName').html(CURENT_USER.UserName);
            $('#assign-user').children().remove();
            for (var i in CURENT_UserList) {
                $('#assign-user').append("<option value='" + CURENT_UserList[i].UserID + "'>" + CURENT_UserList[i].UserName + "</option>");
            }
            $('#assign-device').children().remove();
            for (var i in CURENT_FreeDeviceList) {
                for (var j in CURRENT_AllDevice) {
                    if (CURENT_FreeDeviceList[i].DeviceID == CURRENT_AllDevice[j].DeviceID) 
                        $('#assign-device').append("<option value='" + CURENT_FreeDeviceList[i].DeviceID + "'>" + CURRENT_AllDevice[i].Name + "</option>");
                }
               
            }
           
        })
    };

    this.UnAssignation = function () {
        //unAssingDevice
    }
};