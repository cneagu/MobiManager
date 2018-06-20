USE MobiManagerDB;

--select * from Users;

EXEC Users_Insert
@UserID = 'd0befd26-867e-437a-ad82-c02b6c239590',
@FirstName = 'Neagu',
@LastName = 'Cristian',
@UserName = 'cneagu',
@Password = 'mobimanager123',
@Role = 'CEO',
@Location = 'Cluj';

EXEC Users_Insert
@UserID = '25c33466-83b9-4571-b081-cb08dbd6649f',
@FirstName = 'Manea',
@LastName = 'Andrei',
@UserName = 'amanea',
@Password = 'mobimanager123',
@Role = 'Software Developer',
@Location = 'Cluj';

EXEC Users_Insert
@UserID = '127e61cf-859c-4031-9a4e-33d465447ac0',
@FirstName = 'Pocol',
@LastName = 'Florin',
@UserName = 'fpocol',
@Password = 'mobimanager123',
@Role = 'Software Developer',
@Location = 'Alba';

EXEC Users_Insert
@UserID = '37015003-be5a-44f8-af59-e88f154f75ad',
@FirstName = 'Pop',
@LastName = 'Denisa',
@UserName = 'dpop',
@Password = 'mobimanager123',
@Role = 'Human Resources Officer',
@Location = 'Cluj';

EXEC Users_Insert
@UserID = 'd172d559-8e4b-4f28-b603-4d38cd659028',
@FirstName = 'Moldovan',
@LastName = 'Maria',
@UserName = 'mmaria',
@Password = 'mobimanager123',
@Role = 'Project Manager',
@Location = 'Cluj';

EXEC Users_Insert
@UserID = '89539647-884e-4388-a7da-d2052177fe00',
@FirstName = 'Groav',
@LastName = 'Mircea',
@UserName = 'mgrozav',
@Password = 'mobimanager123',
@Role = 'Market Specialist',
@Location = 'Zalau';

EXEC Devices_Insert
@DeviceID = '89539647-884e-4388-a7da-d2052177fe00',
@Name = 'Iphone7',
@Manufacturer = 'Apple',
@Type = 0,
@OperatingSystem = 'ios10',
@OSVersion = '1.3',
@Processor = 'a12',
@RAMAmount = 1024;

EXEC Devices_Insert
@DeviceID = '3792e87f-d48a-4343-9d58-ebe6de8be686',
@Name = 'Iphone8',
@Manufacturer = 'Apple',
@Type = 0,
@OperatingSystem = 'ios11',
@OSVersion = '1.3',
@Processor = 'a13',
@RAMAmount = 2048;

EXEC Devices_Insert
@DeviceID = '5370aaf3-7172-481c-a550-710ae5903d4d',
@Name = 'IphoneX',
@Manufacturer = 'Apple',
@Type = 0,
@OperatingSystem = 'ios12',
@OSVersion = '1.3',
@Processor = 'a15',
@RAMAmount = 6144;

EXEC Devices_Insert
@DeviceID = '9b130e7d-7056-42f2-b484-e3989e84902a',
@Name = 'GalaxyS8',
@Manufacturer = 'Samsung',
@Type = 0,
@OperatingSystem = 'AndroidNougat',
@OSVersion = '7.1.2',
@Processor = 'Cortex-A53',
@RAMAmount = 4096;

EXEC Devices_Insert
@DeviceID = '02e31bfc-0ef9-425a-92f4-eb8fe33b2abd',
@Name = 'n1',
@Manufacturer = 'Nokia',
@Type = 1,
@OperatingSystem = 'AndroidLollipop',
@OSVersion = '5.0',
@Processor = 'IntelAtomZ3580',
@RAMAmount = 2048;

EXEC Devices_Insert
@DeviceID = '521b6df5-2a42-480b-b31f-532cde74a8ee',
@Name = '8Sirocco',
@Manufacturer = 'Nokia',
@Type = 0,
@OperatingSystem = 'AndroidOreo',
@OSVersion = '8.0',
@Processor = 'napdragon835',
@RAMAmount = 6144;

EXEC Devices_Insert
@DeviceID = 'f834aa62-7c8e-47d6-a134-9585d4ab39bc',
@Name = 'PixelC',
@Manufacturer = 'Google ',
@Type = 1,
@OperatingSystem = 'AndroidMarshmallow',
@OSVersion = '6.0.1',
@Processor = 'NvidiaTegraX1',
@RAMAmount = 3072;

EXEC Devices_Insert
@DeviceID = '4292ebf0-7515-4651-8cef-057abd384791',
@Name = 'Pixel2',
@Manufacturer = 'Google',
@Type = 0,
@OperatingSystem = 'AndroidOreo',
@OSVersion = '8.0',
@Processor = 'Snapdragon835',
@RAMAmount = 4096;

EXEC Devices_Insert
@DeviceID = 'd6d7eb86-1938-42cf-b5f0-205d24a851b6',
@Name = 'Z5',
@Manufacturer = 'Lenovo ',
@Type = 0,
@OperatingSystem = 'AndroidOreo',
@OSVersion = '8.0',
@Processor = 'Snapdragon636',
@RAMAmount = 6144;

EXEC Devices_Insert
@DeviceID = 'de1980de-2496-4e5c-b08b-e132ca941867',
@Name = 'Tab4',
@Manufacturer = 'Lenovo',
@Type = 1,
@OperatingSystem = 'AndroidNougat',
@OSVersion = '7.0',
@Processor = 'Snapdragon625',
@RAMAmount = 4096;

EXEC DevicesAssignation_SetUser
@DeviceID = 'de1980de-2496-4e5c-b08b-e132ca941867',
@UserID = '127E61CF-859C-4031-9A4E-33D465447AC0';

EXEC DevicesAssignation_SetUser
@DeviceID = '521b6df5-2a42-480b-b31f-532cde74a8ee',
@UserID = 'D172D559-8E4B-4F28-B603-4D38CD659028';

EXEC DevicesAssignation_SetUser
@DeviceID = 'f834aa62-7c8e-47d6-a134-9585d4ab39bc',
@UserID = 'D172D559-8E4B-4F28-B603-4D38CD659028';

EXEC DevicesAssignation_SetUser
@DeviceID = '3792e87f-d48a-4343-9d58-ebe6de8be686',
@UserID = '37015003-BE5A-44F8-AF59-E88F154F75AD';

EXEC DevicesAssignation_SetUser
@DeviceID = '9b130e7d-7056-42f2-b484-e3989e84902a',
@UserID = '37015003-BE5A-44F8-AF59-E88F154F75AD';

--select * from Users
--select * from Devices;
--select * from DevicesAssignation;