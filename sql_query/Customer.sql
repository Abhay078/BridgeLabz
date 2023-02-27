
CREATE DATABASE CustDb;

CREATE TABLE Customer(
id int IDENTITY PRIMARY KEY,
FirstName VARCHAR(30),
LastName VARCHAR(30),
City VARCHAR(30),
Country VARCHAR(30),
Phone BIGINT
);

INSERT INTO Customer VALUES('Abhay','Srivastava','Greater Noida','India','8953171324'),
('Nitik','Sinha','Ghaziabad','India','8953171369'),
('Sanjay','Singh','Varanasi','India','9044682345'),
('Prakhar','Dwivedi','Kanpur','India','7300074321'),
('Siddhant','Tripathi','Allahabad','India','9300074121'),
('Maria','Anders','Berlin','Germany','8300074321'),
('Rama','Singh','Ghaziabad','India','4300074321'),
('Sachin','Kumar','Jaunpur','India','6300074321'),
('Alok','Kumar','Lucknow','India','7030074321'),
('Mario','Kumar','Delhi','India','5300074321');

CREATE TABLE OrderTable(
id int IDENTITY PRIMARY KEY,
OrderDate DATE,
CustomerId int FOREIGN KEY REFERENCES Customer(id),
TotalAmount BIGINT
);

INSERT INTO OrderTable VALUES('12-12-2022',1,4000),
('2022-11-12',1,1200),
('2023-01-12',2,2300),
('2023-02-01',6,3400),
('2023-01-02',4,4500),
('2022-10-11',1,5600),
('2023-02-01',3,6700),
('2023-02-12',8,7800),
('2023-02-01',9,8900),
('2023-12-02',3,9050);

CREATE TABLE OrderItem(
id INT PRIMARY KEY IDENTITY,
OrderId INT FOREIGN KEY REFERENCES OrderTable(id),
ProductId INT,
UnitPrice INT,
Qauntity INT
);

INSERT INTO OrderItem VALUES('12','10','2000','100'),
('4','11','2000','100'),
('13','12','2100','200'),
('7','11','1900','099'),
('4','10','2200','099'),
('9','13','2300','100'),
('6','12','0200','101'),
('8','14','2300','200');

SELECT * FROM OrderItem;

SELECT * FROM Customer WHERE FirstName like 'p%';

SELECT MAX(TotalAmount) as MAX_AMOUNT from OrderTable where id>10;


CREATE PROCEDURE spCustomer @city nvarchar(30) AS 
SELECT * FROM Customer WHERE City=@city 
;

EXEC spCustomer @city='Ghaziabad';

CREATE VIEW ordergreater4000 AS
SELECT * FROM OrderTable where TotalAmount>4000;

SELECT * FROM ordergreater4000;

CREATE INDEX idx_id ON Customer (id,FirstName);

/*last 5 records*/
SELECT TOP 5 * FROM Customer ORDER By id DESC;

/*last record from table*/
SELECT TOP 1 * FROM Customer ORDER BY id DESC;

/*fetch total_cost if unit_price and quantity is given*/
SELECT UnitPrice * Qauntity as Total_Cost FROM OrderItem;

/*DISPLAY EVEN ROWS FROM TABLE*/
SELECT * FROM OrderItem WHERE id%2=0;

/*Last 50 % records in table*/

SELECT * FROM (SELECT TOP 50 PERCENT * FROM Customer ORDER BY id DESC)var ORDER BY id;

/*select distinct records without using distinct keyword*/
SELECT * FROM OrderTable GROUP BY id,OrderDate,CustomerId,TotalAmount HAVING COUNT(id) =1; 

/*INNER JOIN*/
SELECT * FROM Customer INNER JOIN OrderTable ON Customer.id=OrderTable.CustomerId ORDER BY Customer.id;

/*FULL OUTER JOIN*/
SELECT * FROM Customer FULL OUTER JOIN OrderTable ON Customer.id=OrderTable.CustomerId ORDER BY Customer.id;

/*LEFT JOIN*/
SELECT * FROM Customer LEFT JOIN OrderTable ON Customer.id=OrderTable.CustomerId ORDER BY Customer.id;

/*RIGHT JOIN*/
SELECT * FROM Customer RIGHT JOIN OrderTable ON Customer.id=OrderTable.CustomerId ORDER BY Customer.id,OrderTable.id;


