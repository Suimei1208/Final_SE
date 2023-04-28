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

CREATE TABLE Distributor (
	ID VARCHAR(50) PRIMARY KEY,
	Username VARCHAR(50),
	Password VARCHAR(50),
	Name VARCHAR(50),
	Phone VARCHAR(50),
	Email VARCHAR(50)
);

CREATE TABLE StockIssue (
	ID VARCHAR(50) PRIMARY KEY,
	DateOfIssue DATE,
	DistributorCode VARCHAR(50),
	TotalValue DECIMAL,
	Status VARCHAR(50),
	PaymentMethod VARCHAR(50),
	PaymentStatus VARCHAR(50),
	accountant_id INT,
	FOREIGN KEY (accountant_id) REFERENCES Accountants(accountant_id),
	FOREIGN KEY (DistributorCode) REFERENCES Distributor(ID)
);


CREATE TABLE StockIssueDetails (
	ID VARCHAR(50) PRIMARY KEY,
	ExportCode VARCHAR(50),
	ProductCode VARCHAR(50),
	Quantity DECIMAL,
	UnitPrice DECIMAL,
	TotalAmount DECIMAL,
	FOREIGN KEY (ExportCode) REFERENCES StockIssue(ID)
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

CREATE TABLE tblStockInOutSummary(
	ID varchar(30) PRIMARY KEY,
	ItemCode varchar(30),
	QuantityOut int,
	QuantityIn int
	FOREIGN KEY (ItemCode) REFERENCES Products(ProductID)
)

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

CREATE TRIGGER trg_DeleteStockInOutSummary
ON tblStockReceiptDetails
AFTER DELETE
AS
BEGIN
    DELETE s
    FROM tblStockInOutSummary s
    JOIN deleted d ON s.ItemCode = d.ProductCode
    WHERE s.QuantityIn = d.Quantity;
END




select * from Products
select * from StockIssue
delete from tblStockInOutSummary
delete from tblStockReceiptDetails
select * from tblStockInOutSummary
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

INSERT INTO Distributor (ID, Username, Password, Name, Phone, Email)
VALUES
('DL001', 'user1', '123456', 'John Doe', '123456789', 'john.doe@example.com'),
('DL002', 'user2', '123456', 'Jane Doe', '987654321', 'jane.doe@example.com'),
('DL003', 'user3', '123456', 'Bob Smith', '012345678', 'bob.smith@example.com'),
('DL004', 'user4', '123456', 'Alice Johnson', '555555555', 'alice.johnson@example.com'),
('DL005', 'user5', '123456', 'David Lee', '111111111', 'david.lee@example.com'),
('DL006', 'user6', '123456', 'Emily Davis', '222222222', 'emily.davis@example.com'),
('DL007', 'user7', '123456', 'Steven Brown', '333333333', 'steven.brown@example.com'),
('DL008', 'user8', '123456', 'Lisa Chen', '444444444', 'lisa.chen@example.com'),
('DL009', 'user9', '123456', 'Michael Wilson', '666666666', 'michael.wilson@example.com'),
('DL010', 'user10', '123456', 'Samantha Lee', '777777777', 'samantha.lee@example.com');


--Test
INSERT INTO StockIssue (ID, DateOfIssue, DistributorCode, TotalValue, Status, PaymentMethod, PaymentStatus)
VALUES
('SI001', '2022-01-01', 'DL001', 100000, 'pending', 'cash', 'unpaid'),
('SI002', '2022-01-02', 'DL002', 200000, 'delivered', 'credit card', 'paid'),
('SI003', '2022-01-03', 'DL003', 300000, 'cancelled', 'bank transfer', 'unpaid'),
('SI004', '2022-01-04', 'DL004', 400000, 'pending', 'cash', 'unpaid'),
('SI005', '2022-01-05', 'DL005', 500000, 'delivered', 'credit card', 'paid');

INSERT INTO StockIssueDetails (ID, ExportCode, ProductCode, Quantity, UnitPrice, TotalAmount)
VALUES
('SID001', 'SI001', 'PD001', 10, 5000, 50000),
('SID002', 'SI001', 'PD002', 20, 10000, 200000),
('SID003', 'SI002', 'PD003', 30, 15000, 450000),
('SID004', 'SI003', 'PD004', 40, 20000, 800000),
('SID005', 'SI004', 'PD005', 50, 25000, 1250000);