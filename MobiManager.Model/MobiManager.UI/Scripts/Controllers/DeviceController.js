var DeviceController = function (serviceContext) {

    $('.close').on('click', function (e) {
        $(this)
            .find("input,textarea,select")
            .val('')
            .end()
            .find("input[type=checkbox], input[type=radio]")
            .prop("checked", "")
            .end();
    });
    function populateDeviceDetail(data) {
        CURENT_Device = [];
        CURENT_Device = data;
        $("#current-Device-Name").html(CURENT_Device.Name);
        $("#current-Device-Manufacturer").html(CURENT_Device.Manufacturer);
        $("#current-Device-Type").html((CURENT_Device.Type == 0) ? "phone" : "tablet");
        $("#current-Device-OperatingSystem").html(CURENT_Device.OperatingSystem);
        $("#current-Device-OSVersion").html(CURENT_Device.OSVersion);
        $("#current-Device-Processor").html(CURENT_Device.Processor);
        $("#current-Device-RAMAmount").html(CURENT_Device.RAMAmount);
    }

    function DeviceSuccessUpdate(data) {
        $("#DeviceDetail .close").click();
        alert('update successful');
        serviceContext.UserService().DevicesList('', PopulateDeviceList);
    }

    this.DeviceDetails = function () {
        $('#profile').on('click', '.deviceDetail' , function () {
            var deviceID = $(this).data('guid');
            $(".currentDevice").html('');

            serviceContext.DeviceService().ReadByID(deviceID, populateDeviceDetail);
        });
    };

    this.DeviceUpdate = function () {
        $('#update-device-details').on('click', function () {
            var device = {
                DeviceID: CURENT_Device.DeviceID,
                Name: $('#details-device-name').val(),
                Manufacturer: $('#details-device-manufacturer').val(),
                
                OperatingSystem: $('#details-device-operatingSystem').val(),
                OSVersion: $('#details-device-osVersion').val(),
                Processor: $('#details-device-processor').val(),
                RAMAmount: validateDigit($('#details-device-ramAmount').val())
            }
            var Type = $('#details-device-type').val();
            if (Type == null) {
                alert('select type');
            }
            else {
                if (validate(device) == 1) {
                    var deviceOK = {
                        DeviceID: device.DeviceID,
                        Name: device.Name,
                        Manufacturer: device.Manufacturer,
                        Type: Type,
                        OperatingSystem: device.OperatingSystem,
                        OSVersion: device.OSVersion,
                        Processor: device.Processor,
                        RAMAmount: device.RAMAmount
                    }
                    serviceContext.DeviceService().Update(deviceOK, DeviceSuccessUpdate);

                }
            }
        });
    }
};