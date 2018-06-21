var DeviceController = function (serviceContext) {

    function populateDeviceDetail(data) {
        CURENT_Device = data;
        $("#current-Device-Name").html(CURENT_Device.Name);
        $("#current-Device-Manufacturer").html(CURENT_Device.Manufacturer);
        $("#current-Device-Type").html((CURENT_Device.Type == 0) ? "phone" : "tablet");
        $("#current-Device-OperatingSystem").html(CURENT_Device.OperatingSystem);
        $("#current-Device-OSVersion").html(CURENT_Device.OSVersion);
        $("#current-Device-Processor").html(CURENT_Device.Processor);
        $("#current-Device-RAMAmount").html(CURENT_Device.RAMAmount);
    }

    this.DeviceDetails = function () {
        $('#profile').on('click', '.deviceDetail' , function () {
            var deviceID = $(this).data('guid');
            $(".currentDevice").html('');

            serviceContext.DeviceService().ReadByID(deviceID, populateDeviceDetail);
        });
    };
};