var ServiceContext = function () {
    var _deviceAssignationService;
    var _deviceService;
    var _userService;

    this.DeviceAssignationService = function () {
        if (!_deviceAssignationService) {
            _deviceAssignationService = new DeviceAssignationService();
        }
        return _deviceAssignationService;
    };

    this.DeviceService = function () {
        if (!_deviceService) {
            _deviceService = new DeviceService();
        }
        return _deviceService;
    };

    this.UserService = function () {
        if (!_userService) {
            _userService = new UserService();
        }
        return _userService;
    };
};