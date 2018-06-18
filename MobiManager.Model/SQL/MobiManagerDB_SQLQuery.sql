CREATE DATABASE MobiManagerDB;
GO

USE MobiManagerDB;

CREATE TABLE [Users](
	[UserID] uniqueidentifier NOT NULL,
	[FirstName] nvarchar(50) NOT NULL,
	[LastName] nvarchar(50) NOT NULL,
	[UserName] nvarchar(50) NOT NULL,
	[Password] nvarchar(50) NOT NULL,
	[Role] nvarchar(50) NOT NULL,
	[CreationDate] datetime,
	[Location] nvarchar(50) NOT NULL,
CONSTRAINT [PK_Users] PRIMARY KEY ([UserID]));

CREATE TABLE [Devices](
	[DeviceID] uniqueidentifier NOT NULL,
	[Name] nvarchar(50) NOT NULL,
	[Manufacturer] nvarchar(50) NOT NULL,
	[Type] bit NOT NULL,
	[OperatingSystem] nvarchar(50) NOT NULL,
	[OSVersion] nvarchar(10) NOT NULL,
	[Processor] nvarchar(50) NOT NULL,
	[RAMAmount] int NOT NULL,
CONSTRAINT [PK_Devices] PRIMARY KEY ([DeviceID]));

CREATE TABLE [DevicesAssignation](
	DeviceID uniqueidentifier NOT NULL,
	UserID uniqueidentifier,
CONSTRAINT [PK_DevicesAssignation] PRIMARY KEY (DeviceID),
CONSTRAINT [FK_DevicesAssignation_DeviceID] FOREIGN KEY (DeviceID)
	REFERENCES Devices(DeviceID) ON DELETE CASCADE,
CONSTRAINT [FK_DevicesAssignation_UserID] FOREIGN KEY (UserID)
	REFERENCES Users(UserID) ON DELETE SET NULL);
GO
--STORED PROCEDURES INSERT

CREATE PROCEDURE dbo.Users_Insert
(
	@UserID uniqueidentifier,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Role nvarchar(50),
	@Location nvarchar(50)
)
AS
BEGIN
	INSERT INTO [Users](UserID,FirstName,LastName,UserName,[Password],[Role],CreationDate,[Location])
	VALUES(@UserID,@FirstName,@LastName,@UserName,@Password,@Role,GETDATE(),@Location)
END
GO

CREATE PROCEDURE dbo.Devices_Insert
(
	@DeviceID uniqueidentifier,
	@Name nvarchar(50),
	@Manufacturer nvarchar(50),
	@Type bit,
	@OperatingSystem nvarchar(50),
	@OSVersion nvarchar(10),
	@Processor nvarchar(50),
	@RAMAmount int
)
AS
BEGIN
	INSERT INTO Devices(DeviceID,[Name],Manufacturer,[Type],OperatingSystem,OSVersion,Processor,RAMAmount)
	VALUES(@DeviceID,@Name,@Manufacturer,@Type,@OperatingSystem,@OSVersion,@Processor,@RAMAmount)
END
GO

--STORED PROCEDURES UPDATE

CREATE PROCEDURE dbo.Users_UpdateByID
(
	@UserID uniqueidentifier,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Role nvarchar(50),
	@Location nvarchar(50)
)
AS
BEGIN
	UPDATE [Users] SET
	FirstName = @FirstName,
	LastName =@LastName,
	UserName =  @UserName,
	[Password] = @Password,
	[Role] = @Role,
	[Location] = @Location
	WHERE [UserID] = @UserID
END
GO

CREATE PROCEDURE dbo.Devices_UpdateByID
(
	@DeviceID uniqueidentifier,
	@Name nvarchar(50),
	@Manufacturer nvarchar(50),
	@Type bit,
	@OperatingSystem nvarchar(50),
	@OSVersion nvarchar(10),
	@Processor nvarchar(50),
	@RAMAmount int
)
AS
BEGIN
	UPDATE [Devices] SET
	[Name] = @Name,
	Manufacturer =@Manufacturer,
	[Type] = @Type,
	OperatingSystem = @OperatingSystem,
	OSVersion = @OSVersion,
	Processor = @Processor,
	RAMAmount = @RAMAmount
	WHERE DeviceID = @DeviceID
END
GO

CREATE PROCEDURE dbo.DevicesAssignation_SetUser
(
	@DeviceID uniqueidentifier,
	@UserID uniqueidentifier
)
AS
BEGIN
	UPDATE [DevicesAssignation] SET
	UserID = @UserID
	WHERE DeviceID = @DeviceID
END
GO

CREATE PROCEDURE dbo.DevicesAssignation_RemoveUser
(
	@DeviceID uniqueidentifier
)
AS
BEGIN
	UPDATE [DevicesAssignation] SET
	UserID = NULL
	WHERE DeviceID = @DeviceID
END
GO

--STORED PROCEDURES DELETE

CREATE PROCEDURE dbo.Users_DeleteByID
(
	@UserID uniqueidentifier
)
AS
BEGIN

	DELETE FROM [Users]
	WHERE [UserID] = @UserID
END
GO

CREATE PROCEDURE dbo.Devices_DeleteByID
(
	@DeviceID uniqueidentifier
)
AS
BEGIN

	DELETE FROM Devices
	WHERE DeviceID = @DeviceID
END
GO

-- STORED PROCEDURE READ

CREATE PROCEDURE dbo.Users_ReadAll
AS
BEGIN
	SELECT  [UserID],
			FirstName,
			LastName,
			UserName,
			[Password],
			[Role],
			CreationDate,
			[Location]
	FROM	[Users]
END
GO

CREATE PROCEDURE dbo.Devices_ReadAll
AS
BEGIN
	SELECT  DeviceID,
			[Name],
			Manufacturer,
			[Type],
			OperatingSystem,
			OSVersion,
			Processor,
			RAMAmount
	FROM	Devices
END
GO

CREATE PROCEDURE dbo.DevicesAssignation_ReadAll
AS
BEGIN
	SELECT  DeviceID,
			UserID
	FROM	DevicesAssignation
END
GO

CREATE PROCEDURE dbo.Users_ReadByID
(
@UserID uniqueidentifier
)
AS
BEGIN
	SELECT  [UserID],
			FirstName,
			LastName,
			UserName,
			[Password],
			[Role],
			CreationDate,
			[Location]
	FROM	[Users]
	WHERE	[UserID] = @UserID
END
GO

CREATE PROCEDURE dbo.Users_ReadUserName
(
@UserName nvarchar(50)
)
AS
BEGIN
	SELECT UserName
	FROM	[Users]
	WHERE	UserName = @UserName
END
GO

CREATE PROCEDURE dbo.Devices_ReadByID
(
@DeviceID uniqueidentifier
)
AS
BEGIN
	SELECT  DeviceID,
			[Name],
			Manufacturer,
			[Type],
			OperatingSystem,
			OSVersion,
			Processor,
			RAMAmount
	FROM	Devices
	WHERE	DeviceID = @DeviceID
END
GO

CREATE PROCEDURE dbo.DevicesAssignation_ReadByID
(
@DeviceID uniqueidentifier
)
AS
BEGIN
	SELECT  DeviceID,
			UserID
	FROM	DevicesAssignation
	WHERE	DeviceID = @DeviceID
END
GO

CREATE PROCEDURE dbo.DevicesAssignation_FreeDevices
AS
BEGIN
	SELECT  DeviceID,
			UserID
	FROM	DevicesAssignation
	WHERE	UserID  IS NULL
END
GO

CREATE PROCEDURE dbo.DevicesList
AS
BEGIN
SELECT  d.DeviceID,
			d.[Name],
			d.Manufacturer,
			u.UserID,
			u.FirstName,
			u.LastName
	FROM	Devices d
	INNER JOIN DevicesAssignation a ON a.DeviceID = d.DeviceID
	LEFT JOIN Users u ON  u.UserID = a.UserID;
END
GO

--Triggers

CREATE TRIGGER [dbo].[Insert_DevicesAssignation]
ON [dbo].[Devices]
 AFTER INSERT
AS
BEGIN
INSERT INTO DevicesAssignation(DeviceID)
SELECT DeviceID FROM inserted
END
GO