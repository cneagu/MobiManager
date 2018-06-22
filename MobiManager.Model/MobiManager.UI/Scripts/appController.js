$(document).ready(function () {
    SPA();
    var _serviceContext = new ServiceContext();

    var _userController = new UserController(_serviceContext);
    _userController.SigIn();
    _userController.LogIn();
    _userController.LogOut();
    _userController.Setings();

    var _deviceController = new DeviceController(_serviceContext);
    _deviceController.DeviceDetails();
    _deviceController.DeviceUpdate();
    _deviceController.DeviceDelete();
    _deviceController.NewDevice();

    var _deviceAssignationController = new DeviceAssignationController(_serviceContext);
    _deviceAssignationController.Assignation();
    _deviceAssignationController.UnAssignation();
});