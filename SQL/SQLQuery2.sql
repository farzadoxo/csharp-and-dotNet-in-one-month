GO
CREATE PROC Usp_Users_GetAllData
AS
BEGIN
SELECT * FROM Users
END


GO
CREATE PROC Usp_Users_GetById
@Id INT
AS
BEGIN 
SELECT * FROM Users WHERE Id=@Id
END


DROP PROC Usp_Users_GetById


GO
CREATE PROC Usp_Users_AddUser
@Name NVARCHAR(128),
@Email NVARCHAR(128)
AS
BEGIN
INSERT INTO Users(FullName,Email) VALUES(@Name,@Email)
END

SELECT * FROM Users 