USE WebStore
GO
CREATE TABLE Category(
	[CategoryId] SmallInt IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[CategoryName] [nvarchar](64) NOT NULL
);
Go
CREATE TABLE Product (
ProductId INT  NOT NULL PRIMARY KEY IDENTITY(1, 1),
CategoryId SMALLINT NOT NULL,
ProductName NVARCHAR(64) NOT NULL,
Description NVARCHAR(MAX) NOT NULL,
Price DECIMAL(18, 2) NOT NULL,
Quantity SMALLINT NOT NULL,
ImageUrl VARCHAR(32) NOT NULL
);

INSERT INTO Product (CategoryId, ProductName, Description, Price, Quantity, ImageUrl)
VALUES
(1, 'Laptop DELL', N'Máy tính xách tay DELL', 72.3, 1, 'dell.png'),
(1, 'Laptop Asus', N'Máy tính xách tay Asus', 93.8, 1, 'asus.png');
Go

