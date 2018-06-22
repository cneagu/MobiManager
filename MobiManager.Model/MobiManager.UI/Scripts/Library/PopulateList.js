function PopulateDeviceList(devices) {
    $("#devicesList .toRemove").remove();

    for (var i in devices) {
        var str = "<tr class='toRemove'>" +
            "<td>" +
            '<input id="checkBox" type="checkbox">' +
            '</td>' +
            '<td scope="row">' + i + '</td>' +
            '<td>' + devices[i].Name + '</td>' +
            '<td>' + devices[i].FirstName + ' ' + devices[i].LastName + '</td>' +
            '<td>' +
            '<a data-guid="' + devices[i].DeviceID + '" href="details.html" class="btn btn-secondary deviceDetail" data-toggle="modal" data-target="#DeviceDetail">' +
            '<i class="fa fa-angle-double-right"></i> Details' +
            '</a>' +
            '</td>' +
            '<td>' +
            ' <a data-guid="' + devices[i].DeviceID + '" href="#user_profile" class="btn btn-danger deviceDelete">' +
            '<i class="fa fa-trash"></i>' +
            '</a>' +
            '</td>' +
            '</tr>';
        $('#devicesList').append(str);
    }
}

function PopulateUserList(data) {
    CURENT_UserList = data;
    console.log(CURENT_UserList);
}