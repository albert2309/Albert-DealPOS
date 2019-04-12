CREATE DATABASE DealPOSTest;
/*Make sure you allow the SQL Server auth mode */
CREATE LOGIN LoginScott
WITH PASSWORD = 'pwd!23',
DEFAULT_DATABASE = "DealPOSTest"
GO
USE DealPOSTest;
DROP TABLE Phone;
DROP Table Person;
CREATE TABLE Person(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
Full_name VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Phone(
ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
PersonID INT FOREIGN KEY REFERENCES Person(ID) NOT NULL,
Phone VARCHAR(30) NOT NULL
);
CREATE USER Scott FOR LOGIN LoginScott;
EXEC sp_addsrvrolemember 'LoginScott', 'sysadmin';
GO;

CREATE PROCEDURE export
AS
SELECT Full_name, Phone FROM Person INNER JOIN Phone ON Person.ID = Phone.PersonID ORDER BY Full_name ASC;

BACKUP DATABASE DealPOSTest
TO DISK = 'D:\DealPOSBackup.bak'

RESTORE DATABASE DealPOSTest
FROM DISK = 'DealPOSBackup.bak'
with replace, recovery