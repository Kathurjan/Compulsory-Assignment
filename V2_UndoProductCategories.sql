USE ECommerce
GO

ALTER TABLE Product
DROP CONSTRAINT FK__Product__Categor__3C69FB99
GO

DROP TABLE Categories
GO