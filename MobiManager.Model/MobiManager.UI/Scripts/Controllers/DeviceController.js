var DeviceController = function (serviceContext) {

    this.DeviceDetails = function () {
        $('#profile').on('click', '.deviceDetail', function () {
            $('.det').val('');
            var deviceID = $(this).data('guid');
            $(".currentDevice").html('');

            serviceContext.DeviceService().ReadByID(deviceID, populateDeviceDetail);
        });
    };

    this.DeviceUpdate = function () {
        $('#update-device-details').on('click', function () {
            var device = {
                DeviceID: CURENT_Device.DeviceID,
                Name: $('#details-device-name').val() == '' ? CURENT_Device.Name : $('#details-device-name').val(),
                Manufacturer: $('#details-device-manufacturer').val() == '' ? CURENT_Device.Manufacturer : $('#details-device-manufacturer').val(),
                Type: $('#details-device-type').val() == '' ? CURENT_Device.Type : $('#details-device-type').val(),
                OperatingSystem: $('#details-device-operatingSystem').val() == '' ? CURENT_Device.OperatingSystem : $('#details-device-operatingSystem').val(),
                OSVersion: $('#details-device-osVersion').val() == '' ? CURENT_Device.OSVersion : $('#details-device-osVersion').val(),
                Processor: $('#details-device-processor').val() == '' ? CURENT_Device.Processor : $('#details-device-processor').val(),
                RAMAmount: $('#details-device-ramAmount').val() == '' ? CURENT_Device.RAMAmount : $('#details-device-ramAmount').val()
            }
            var Type = $('#details-device-type').val();
            if (validateDigit($('#details-device-ramAmount').val()) != 0) {
                alert('invalid Ram');
            }
            else {
                serviceContext.DeviceService().Update(device, DeviceSuccessUpdate);
            }
        });
    }

    this.DeviceDelete = function () {
        $('#profile').on('click', '.deviceDelete', function () {
            var deviceID = $(this).data('guid');
            console.log(deviceID);

            serviceContext.DeviceService().Delete(deviceID, DeleteDevice);
        });
    }

    this.NewDevice = function () {
        $('#newDeviceModal').on('click', function () {
            $('.newe').val('');
        });

        $('#new-device').on('click', function () {
        var device = {
              
            Name: $('#new-name').val(),
            Manufacturer: $('#new-manufacturer').val(),

            OperatingSystem: $('#new-operatingSystem').val(),
            OSVersion: $('#new-osVersion').val(),
            Processor: $('#new-processor').val(),
            RAMAmount: validateDigit($('#new-ramAmount').val())
        }
        var Type = $('#new-type').val();
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
                serviceContext.DeviceService().Insert(deviceOK, DeviceSuccessInsert);
            }
        }
        });
    }

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
        serviceContext.DeviceAssignationService().GetFreeDevice('', PopulateFreeDeviceList);
    }

    function DeleteDevice(data) {
        alert('success delete');
        serviceContext.UserService().DevicesList('', PopulateDeviceList);
        serviceContext.DeviceAssignationService().GetFreeDevice('', PopulateFreeDeviceList);
    }

    function DeviceSuccessInsert(data) {
        $("#addNewDevice .close").click();
        alert('create successful');
        serviceContext.UserService().DevicesList('', PopulateDeviceList);
        serviceContext.DeviceAssignationService().GetFreeDevice('', PopulateFreeDeviceList);
    }
};