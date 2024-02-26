USE ECommerce
GO
CREATE TABLE ProductRatings (
RateId INT PRIMARY KEY,
ProductId INT, 
Rate INT,
FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
);
GO