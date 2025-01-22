
-- Create database for my allpication and use it
CREATE DATABASE My_App
GO 
USE My_App
GO

-- Create tables and constractor
CREATE TABLE [User](
ID INT PRIMARY KEY ,
[Name] NVARCHAR(128),
Age INT CHECK(Age >= 18),
Email NVARCHAR(200) UNIQUE
)

-- Some column's need to change
ALTER TABLE [User]
ADD CONSTRAINT DF_EMAIL DEFAULT 'EXAMPLE@GMAIL.COM' FOR Email


-- add another table 
CREATE TABLE Test (
ID INT IDENTITY,
TEST NVARCHAR
)

ALTER TABLE Test
ALTER COLUMN TEST NVARCHAR(15)


--ALTER TABLE Test
--ADD CONSTRAINT MOLA IDENTITY(3,3) FOR ID


-- drop all tables
DROP TABLE Test
DROP TABLE [User]





--  NEW QUERIES --
CREATE TABLE Producers
(
ID INT PRIMARY KEY,
FullName NVARCHAR(50),
)


CREATE TABLE Movies
(
ID INT PRIMARY KEY IDENTITY ,
[Name] NVARCHAR(50) NOT NULL,
ProducerID INT NOT NULL,
CONSTRAINT FK_MovieTOProducer FOREIGN KEY (ProducerID) REFERENCES Producers(ID)
)




SELECT * FROM Movies WHERE ProducerID = 555444


SELECT ProductID , [Name] FROM SalesLT.Product ORDER BY ProductID OFFSET 10 ROWS
FETCH NEXT 20 ROWS ONLY

	



SELECT [Name] , Color FROM SalesLT.Product

SELECT * FROM SalesLT.Product WHERE ProductID BETWEEN 700 AND 1000

SELECT * FROM SalesLT.Product WHERE [Name] LIKE '%S%'

SELECT * FROM SalesLT.Product WHERE [Name] LIKE '_L%'

SELECT * FROM SalesLT.Product WHERE Color NOT LIKE '[RB]%'

SELECT * FROM SalesLT.Product WHERE Color  LIKE '[RB]%'

SELECT * FROM SalesLT.Product WHERE ProductID LIKE '_[5-7]%'

SELECT ASCII('T') AS K


select * from saleslt.product 
SELECT * FROM SalesLT.Product ORDER BY ProductID OFFSET 5 ROWS
FETCH NEXT 4 ROWS ONLY


SELECT * FROM SalesLT.Customer WHERE [FirstName] LIKE '__e%'

SELECT * FROM SalesLT.Customer WHERE CustomerID BETWEEN 400 AND 450 ORDER BY CustomerID OFFSET 10 ROWS
FETCH FIRST 2 ROWS ONLY