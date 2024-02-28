USE ECommerce;
GO

CREATE TABLE Categories (
	CategoryId INT Primary Key,
	CName Varchar(255) Unique,
)
GO

ALTER TABLE Product 
ADD 
CategoryId_FK INT Foreign Key(CategoryId_FK) 
References Categories(CategoryId);
GO