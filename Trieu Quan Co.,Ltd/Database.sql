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
	SupplierCode varchar(50),
	TotalValue int,
);


create table tblStockReceiptDetails(
	ID varchar(50) PRIMARY KEY,
	StockReceiptCode varchar(50),
	ProductCode varchar(50),
	Quantity int,
	UnitPrice int,
	TotalAmount int,
	FOREIGN KEY (StockReceiptCode) REFERENCES tblStockReceipt(ID)
	);

create table tblStockIssue(
	ID varchar(50) PRIMARY KEY,
	DateOfIssue date,
	DistributorCode varchar(50),
	TotalValue int
);

create table tblStockIssueDetails(
	ID varchar(50) PRIMARY KEY,
	ExportCode varchar(50),
	ProductCode varchar(50),
	Quantity int,
	UnitPrice int,
	TotalAmount int,
	FOREIGN KEY (ExportCode) REFERENCES tblStockIssue(ID)
);

create table Products(
	ProductID  varchar(30) PRIMARY KEY,
	ProductName varchar(30),
	Quantity int,
	UnitPrice int
);

create table Suppliers(
	SupplierID varchar(30) PRIMARY KEY,
	SupplierName varchar(30),
	PhoneNumber varchar(30),
	Email  varchar(30)
);

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
