CREATE DATABASE viewDB;
USE viewDB;

CREATE TABLE Authors(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(15),
    Surname NVARCHAR(15)
);

CREATE TABLE Books(
    Id INT IDENTITY PRIMARY KEY,
    AuthorId INT REFERENCES Authors(Id),
    Name NVARCHAR(100) CHECK (LEN(Name) >= 2),
    PageCount INT CHECK (PageCount >= 10)
);

INSERT INTO Authors (Name, Surname) VALUES ('Haruki', 'Murakami')
INSERT INTO Authors (Name, Surname) VALUES ('J.K.', 'Rowling')
INSERT INTO Authors (Name, Surname) VALUES ('Leo', 'Tolstoy')
INSERT INTO Authors (Name, Surname) VALUES ('Stephen', 'King')
INSERT INTO Authors (Name, Surname) VALUES ('Ernest', 'Hemingway')

INSERT INTO Books (AuthorId, Name, PageCount) VALUES (1, 'Kafka on the Shore', 505);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (2, 'Harry Potter and the Philosophers Stone', 223)
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (3, 'War and Peace', 1225);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (4, 'The Shining', 447);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (5, 'The Old Man and the Sea', 127);


CREATE VIEW GetData
AS
SELECT 
    Books.Id AS BookID, 
    Books.Name AS BookName, 
    Books.PageCount AS BookCount, 
    CONCAT(Authors.Name, ' ', Authors.Surname) AS AuthorFullName 
FROM Books
JOIN Authors ON Books.AuthorId = Authors.Id;

SELECT * FROM GetData;

CREATE PROCEDURE GetInfoProcedure @SearchName NVARCHAR(15)
AS
BEGIN
    SELECT 
        Books.Id AS BookID,
        Books.Name AS BookName,
        Books.PageCount AS BookCount,
        CONCAT(Authors.Name, ' ', Authors.Surname) AS AuthorFullName
    FROM Books
    JOIN Authors ON Books.AuthorId = Authors.Id
    WHERE Authors.Name = @SearchName OR Books.Name = @SearchName;
END;
GO

EXEC GetInfoProcedure 'War and Peace';

CREATE FUNCTION CountBooksPageCount (@MinPageCount INT = 10)
RETURNS INT
AS
BEGIN 
    DECLARE @BookCount INT;
    SELECT @BookCount = COUNT(*) FROM Books WHERE PageCount > @MinPageCount;
    RETURN @BookCount;
END;

SELECT dbo.CountBooksPageCount(400);
