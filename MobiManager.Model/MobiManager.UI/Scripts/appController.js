$(document).ready(function () {
    SPA();
    var _serviceContext = new ServiceContext();

    var _userController = new UserController(_serviceContext);
    _userController.SigIn();
    _userController.LogIn();
    _userController.LogOut();
    _userController.Setings ();
});