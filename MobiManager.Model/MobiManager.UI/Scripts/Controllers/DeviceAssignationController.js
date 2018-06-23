var DeviceAssignationController = function (serviceContext) {

    this.Assignation = function () {
        $('#assingDeviceModal').on('click', function () {
            //set user options
            $('#current-assign-UserName').html(CURENT_USER.UserName);
            $('#assign-user-op').children().remove();
            for (var i in CURENT_UserList) {
                $('#assign-user-op').append("<option value='" + CURENT_UserList[i].UserID + "'>" + CURENT_UserList[i].UserName + "</option>");
            }
            $('#assign-device-op').children().remove();
            for (var i in CURENT_FreeDeviceList) {
                for (var j in CURRENT_AllDevice) {
                    if (CURENT_FreeDeviceList[i].DeviceID == CURRENT_AllDevice[j].DeviceID)
                        $('#assign-device-op').append("<option value='" + CURENT_FreeDeviceList[i].DeviceID + "'>" + CURRENT_AllDevice[i].Name + "</option>");
                }
            }
        });

        function DeviceAssignationCallback(data) {
            alert('Device assign');
            serviceContext.UserService().DevicesList('', PopulateDeviceList);
            serviceContext.DeviceAssignationService().GetFreeDevice('', PopulateFreeDeviceList);
            serviceContext.DeviceAssignationService().ReadByID(CURENT_USER.UserID, PopulateDeviceAssignList);
        }

        $('#assign-device-button').on('click', function () {
            var assign = {
                DeviceID: dropdownValidate($('#assign-device-op').val(), '#assign-device-op'),
                UserID: dropdownValidate($('#assign-user-op').val(), '#assign-user-op')
            };
            if (validate(assign) == 1) {
                serviceContext.DeviceAssignationService().SetUser(assign, DeviceAssignationCallback);
            }

        });
    };

    this.UnAssignation = function () {
        //unAssingDevice
    }
};