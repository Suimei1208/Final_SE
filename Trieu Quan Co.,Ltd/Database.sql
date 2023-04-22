CREATE DATABASE Final_SE

CREATE TABLE Accountants (
    accountant_id INT PRIMARY KEY,
    accountant_name VARCHAR(50),
    username VARCHAR(50),
    password VARCHAR(50),
);
INSERT INTO Accountants
VALUES (1, 'Admin', 'admin', '123456789'),
       (2, 'Trieu', 'suimei', '123456789'),
       (3, 'Quan', 'quan', 'p@123456789');

drop table Accountants