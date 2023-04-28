CREATE DATABASE Final_SE

CREATE TABLE Accountants(
    accountant_id INT PRIMARY KEY,
    accountant_name VARCHAR(50),
    username VARCHAR(50),
    password VARCHAR(50)
);
create table tblStockReceipt(
	ID varchar(50) PRIMARY KEY,
	DateOfReceipt date,
	accountant_id int,
	FOREIGN KEY (accountant_id) REFERENCES Accountants(accountant_id),
	SupplierCode varchar(50),
	TotalValue decimal,
);


create table tblStockReceiptDetails(
	ID varchar(50) PRIMARY KEY,
	StockReceiptCode varchar(50),
	ProductCode varchar(50),
	Quantity decimal,
	UnitPrice decimal,
	TotalAmount decimal,
	FOREIGN KEY (StockReceiptCode) REFERENCES tblStockReceipt(ID)
	);

create table tblStockIssue(
	ID varchar(50) PRIMARY KEY,
	DateOfIssue date,
	DistributorCode varchar(50),
	TotalValue decimal,
	Status varchar(50)
);

create table tblStockIssueDetails(
	ID varchar(50) PRIMARY KEY,
	ExportCode varchar(50),
	ProductCode varchar(50),
	Quantity decimal,
	UnitPrice decimal,
	TotalAmount decimal,
	FOREIGN KEY (ExportCode) REFERENCES tblStockIssue(ID)
);

create table Products(
	ProductID  varchar(30) PRIMARY KEY,
	ProductName varchar(30),
	Quantity decimal,
	UnitPrice decimal
);

create table Suppliers(
	SupplierID varchar(30) PRIMARY KEY,
	SupplierName varchar(30),
	PhoneNumber varchar(30),
	Email  varchar(30)
);

CREATE TRIGGER update_product_details
ON tblStockReceiptDetails
AFTER INSERT, UPDATE
AS
BEGIN
-- Kiểm tra nếu trigger được kích hoạt bởi INSERT
IF EXISTS(SELECT * FROM inserted)
BEGIN
UPDATE Products
SET Quantity = Products.Quantity + (SELECT SUM(Quantity) FROM inserted WHERE ProductCode = Products.ProductID),
UnitPrice = (SELECT UnitPrice FROM inserted WHERE ProductCode = Products.ProductID)
WHERE ProductID IN (SELECT ProductCode FROM inserted);
END
-- Kiểm tra nếu trigger được kích hoạt bởi UPDATE
ELSE IF EXISTS(SELECT * FROM deleted)
BEGIN
UPDATE p
SET Quantity = CASE
WHEN p.Quantity <= i.Quantity
THEN p.Quantity + (i.Quantity - d.Quantity)
ELSE
p.Quantity - (d.Quantity - i.Quantity)
END,
UnitPrice = i.UnitPrice
FROM Products p
INNER JOIN deleted d ON p.ProductID = d.ProductCode
INNER JOIN inserted i ON i.ID = d.ID
WHERE p.ProductID IN (SELECT ProductCode FROM inserted UNION SELECT ProductCode FROM deleted);
END

END;

GO




CREATE TRIGGER trg_UpdateProductQuantity
ON tblStockReceiptDetails
AFTER DELETE
AS
BEGIN
    UPDATE Products
    SET Products.Quantity = Products.Quantity - deleted.Quantity
    FROM Products
    INNER JOIN deleted ON Products.ProductID = deleted.ProductCode
END


select * from Products
select * from tblStockReceipt
delete from tblStockReceipt
delete from tblStockReceiptDetails

SELECT TOP 1 ProductID FROM Products ORDER BY ProductID DESC

INSERT INTO Accountants
VALUES (1, 'Admin', 'admin', '123456789'),
       (2, 'Trieu', 'suimei', '123456789'),
       (3, 'Quan', 'quan', 'p@123456789');

INSERT INTO Products (ProductID, ProductName, Quantity, UnitPrice) VALUES
('SP001', 'Samsung Galaxy S21', 20, 15000000),
('SP002', 'iPhone 12 Pro', 15, 18000000),
('SP003', 'Xiaomi Mi 11 Ultra', 10, 14000000),
('SP004', 'Oppo Find X3 Pro', 5, 16000000),
('SP005', 'Google Pixel 6 Pro', 8, 17000000),
('SP006', 'Sony Xperia 1 III', 12, 13000000),
('SP007', 'LG Velvet 2 Pro', 3, 11000000),
('SP008', 'Vivo X70 Pro+', 7, 12000000),
('SP009', 'Realme GT Master Edition', 9, 10000000),
('SP010', 'Nokia X20', 6, 9000000);

Insert into Suppliers(SupplierID, SupplierName, PhoneNumber, Email) values
('S0001', 'ABC Company', '0123456789', 'abc@gmail.com'),
('S0002', 'XYZ Corporation', '0987654321', 'xyz@yahoo.com'),
('S0003', 'MNO Corporation', '0909090909', 'mno@outlook.com'),
('S0004', 'PQR Limited', '0777777777', 'pqr@hotmail.com'),
('S0005', 'LMN Limited', '0888888888', 'lmn@gmail.com')