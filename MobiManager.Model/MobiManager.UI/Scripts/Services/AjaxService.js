function ajaxService(action, verb, data, handleData, divID) {
    var _url = 'http://localhost:50528/api/';
    var _data = [];
    $(divID).addClass('loader');

    var promise = $.ajax({
        crossDomain: true,
        dataType: "json",
        url: _url + action,
        type: verb,
        data: data
    });
    promise.done(function (data) { handleData(data); });
    promise.fail(function () { alert("error"); });
    promise.always(function () { $(divID).removeClass('loader'); });
};