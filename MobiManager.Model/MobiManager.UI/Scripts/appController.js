$(document).ready(function () {
    SPA();
    var _serviceContext = new ServiceContext();

    var _userController = new UserController(_serviceContext);
    _userController.LogIn();
    _userController.Setings();
    _userController.LogOut();
    _userController.UserProfile();
});