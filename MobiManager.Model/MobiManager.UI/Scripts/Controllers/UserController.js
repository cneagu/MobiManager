var UserController = function (serviceContext) {
    
    this.SigIn = function () {
        var firstName = '';
        $('#new-firstName').focusout(function () {
            firstName = validationText($('#new-firstName').val(), '#new-firstName');
        });
        var lastName = '';
        $('#new-lastName').focusout(function () {
            lastName = validationText($('#new-lastName').val(), '#new-lastName');
        });
        var userName = '';
        $('#new-userName').focusout(function () {
            userName = validateUsername($('#new-userName').val(), '#new-userName');
        });
        var password = '';
        $('#new-password').focusout(function () {
            password = validatePassword($('#new-password').val(), '#new-password');
        });
        var cPassword = $('#new-c-password').focusout(function () {
            cPassword = validaterePassword($('#new-c-password').val(), password, '#new-c-password');
        });

        $('#singIn').on('click', function () {
            var role = dropdownValidate($('#new-role').val(), '#new-role');
            var location = dropdownValidate($('#new-location').val(), '#new-location');
            var terms = validateTerms($('#new-terms').is(':checked') ? 1 : 0);
            if (terms && cPassword !== null) {
                var userInput = {
                    FirstName: firstName,
                    LastName: lastName,
                    UserName: userName,
                    Password: password,
                    Role: role,
                    Location: location
                };
                if (validate(userInput) == 1) {
                    function responseNewUser(data) {
                        alert('New account created!   now you can login :)');
                        window.location.hash = '#home';
                    }

                    function checkteUserData(userName) {
                        if (userName) {
                            if (userName == userInput.UserName)
                                alert('This UserName already exists ' + 'UserName : ' + userName + ' ');
                        } else {
                            serviceContext.UserService().Insert(userInput, responseNewUser)
                        }

                    }
                    serviceContext.UserService().ReadUserName('#singin', userInput.UserName, checkteUserData);
                }
            }
        });
    };   

    this.LogIn = function () {
        var luserName = '';
        $('#username').focusout(function () {
            luserName = validateUsername($('#username').val(), '#username');
        });
        var lpassword = '';
        $('#password').focusout(function () {
            lpassword = validatePassword($('#password').val(), '#password');
        });

        $('#logIn').on('click', function () {
            if (luserName !== '' && lpassword !== '') {
                var logIn = {
                    UserName: luserName,
                    Password: lpassword
                };
                function UserReadByIdCallBack(user) {
                    CURENT_USER = user;
                    $("#loginModal .close").click();
                    $('#user_menu').removeAttr('hidden');
                    $('#login-button').attr("hidden", "true");
                    $('#head-userName').html("<i class='fa fa-user'></i>  " + user.UserName);
                }

                

                function LogInCallBack(guid) {
                    if (guid == '00000000-0000-0000-0000-000000000000') {
                        alert("Account doesn't exist");
                    }
                    else {
                        alert('You are LogIn');
                        window.location.hash = '#user_profile';
                        serviceContext.UserService().ReadById(guid, UserReadByIdCallBack);
                        serviceContext.UserService().DevicesList('', PopulateDeviceList);
                        serviceContext.UserService().ReadAll('', PopulateUserList);
                        //
                    }
                }
                serviceContext.UserService().ReadLogIn(logIn, LogInCallBack);
            }
            else
                alert('Incorect input!');
        });
    };
    this.LogOut = function () {
        $('#logOut').on('click', function () {
            $('#user_menu').attr("hidden", "true");
            $('#login-button').removeAttr('hidden');

            dataDismiss();
            
        });
    };

    this.Setings = function () {
      
        $('.setings').on('click', function () {
            $(".current-setings").html('');
            $("#current-FirstName").html(CURENT_USER.FirstName);
            $("#current-LastName").html(CURENT_USER.LastName);
            $("#current-UserName").html(CURENT_USER.UserName);
            $("#current-Role").html(CURENT_USER.Role);
            $("#current-Location").html(CURENT_USER.Location);
        });

        var firstName = '';
        $('#new-seting-firstName').focusout(function () {
            firstName = validationText($('#new-seting-firstName').val(), '#new-seting-firstName');
        });
        var lastName = '';
        $('#new-seting-LastName').focusout(function () {
            lastName = validationText($('#new-seting-LastName').val(), '#new-seting-LastName');
        });
        var userName = '';
        $('#new-seting-username').focusout(function () {
            userName = validateUsername($('#new-seting-username').val(), '#new-seting-username');
        });
        var nPassword = '';
        $('#new-seting-new-password').focusout(function () {
            nPassword = validatePassword($('#new-seting-new-password').val(), '#new-seting-new-password');
        });
        var cPassword = $('#new-seting-new-cpassword').focusout(function () {
            cPassword = validaterePassword($('#new-seting-new-cpassword').val(), nPassword, '#new-seting-new-cpassword');
        });

        $('#update-setings').on('click', function () {
            var password = validateCurentPassword($('#new-seting-curent-password').val());
            var role = dropdownValidate($('#new-seting-role').val(), '#new-seting-role');
            var location = dropdownValidate($('#new-seting-location').val(), '#new-seting-location');

            if (password !== '' && nPassword === cPassword) {
                var user = {
                    UserID: CURENT_USER.UserID,
                    FirstName: firstName,
                    LastName: lastName,
                    UserName: userName,
                    Password: password,
                    Role: role,
                    Location: location
                };

                if (validate(user) == 1) {
                    serviceContext.UserService().Update(user, callBack);
                }
            }
            else {
                alert('incorect password');
            }
            function callBack(data) {
                alert('Success! You need to Log In again');
                $('#user_menu').attr("hidden", "true");
                $('#login-button').removeAttr('hidden');

                dataDismiss();
            }
        });
    };
};