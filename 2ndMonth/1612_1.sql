select companyname,count(fax)from customers
--�al��maz s�tun ve fonsiyon bir arada kullan�lmaz

select avg(unitprice) from products

select round(avg(unitprice),2) from products
--virg�lden sonra iki basamak getirdi

select sum(unitprice)/count(unitprice),avg(unitprice) from products where categoryId=2
--ayn� ��kt�

select 3+5

select getdate()

select newid()

select min(unitsInstock) from products

select max((unitprice*quantity)*(1-Discount)) from [order details] 

select * from orders

select min(OrderDate) from orders where ShippedDate is null

--sipari�le teslim tarihinin ortalamas�
select avg(DATEDIFF(DAY, orderdate, shippeddate)) from orders
--DATEDIFF(DAY, '1/1/2011', '3/1/2011')

--fiyat� en y�ksek olan�n ismi ve fiyat� yaz�cak
select top 1 productname,unitprice from products order by unitprice desc
--s�tun yan�na fonskiyon gelmez max ve min kullanamay�z

--56 numaral� �r�n�n ortalama ka� paraya sat�yorum
select avg(unitprice*(1-discount)) from [Order Details] where productId = 56

--her �lkede ka� m��terim oldu�unu
select country,count(*) from customers group by country order by count(*) desc

select CategoryID,sum(UnitsInStock) from products group by categoryId

--hangi �al��an ka� sipari� alm��, en az sipari� alan� bul
select EmployeeID,count(*) from orders group by EmployeeID order by count(*) asc

--teslim edilmemi� sipari�lerin �lkelere g�re da��l�m�
select shipcountry,count(*) from orders where shippeddate is null group by shipcountry
order by count(*) asc

select CategoryID,min(unitprice) enucuz,avg(unitprice) ort,max(unitprice) enpahal�
 from products group by CategoryID 

 --JOINLER
 select * from categories
 select * from products

 select * from products INNER JOIN Categories 
 ON Products.CategoryID = Categories.CategoryID
 --tablolar� d�md�z yanyana koydu

  select productname,categoryname 
  from products INNER JOIN Categories 
  ON Products.CategoryID = Categories.CategoryID

  select * from products
  select * from suppliers

  select ProductName,CompanyName 
  from products INNER JOIN Suppliers 
  on products.SupplierID = Suppliers.SupplierID

  select * from [Order Details]
  select * from products

  select OrderID,ProductName,[Order Details].UnitPrice,Quantity,Discount 
  from [Order Details] INNER JOIN products 
  on [Order Details].ProductID= Products.ProductID
  
  select * from orders
  select * from Shippers

  select OrderId,OrderDate,CompanyName,Freight 
  from orders o INNER JOIN Shippers s 
  on o.ShipVia=s.ShipperID

  select * from orders 
  select * from customers
  select * from employees

  select OrderID,CompanyName,FirstName+' '+LastName EmployeeName,OrderDate 
  from Orders INNER JOIN Customers 
  on Orders.CustomerID=Customers.CustomerID INNER JOIN Employees 
  ON Orders.EmployeeID=Employees.EmployeeID

  select * from [Order Details] 
  select * from employees
  select * from orders            
  --ikisi aras�nda arac� bir tablo yard�m� �art oda orders 

  select [Order Details].OrderID,ProductID,UnitPrice,Quantity,Discount,FirstName+' '+LastName EmployeeName from [Order Details] 
  INNER JOIN orders on [Order Details].OrderID= Orders.OrderID
  INNER JOIN Employees on orders.EmployeeID=Employees.EmployeeID
  
  --Hangi �al��an�n ne kadar para kazand�rd���n� bulal�m detayland�rd�k
  select Firstname+' '+LastName, Round(Sum(unitprice*Quantity*(1-discount)),2) Total
  from [Order Details] 
  INNER JOIN orders on [Order Details].OrderID= Orders.OrderID
  INNER JOIN Employees on orders.EmployeeID=Employees.EmployeeID
  group by Firstname+' '+LastName
  order by Total desc

  --category ismi yan�nda �e�itleri yazacak
  select * from products
  select * from Categories

  select CategoryName,count(*) Total from products 
  INNER JOIN Categories ON Products.CategoryID=Categories.CategoryID
  group by products.CategoryID,CategoryName --sevilmeyen bir hile farkl� category�dleri derlemek i�in

  --reports to �al��an�n kime hesap verdi�i
  select firstname,LastName,ReportsTo from employees
  
  select e1.FirstName,e1.LastName,e2.firstname+' '+e2.LastName ReportsTo 
  from employees e1 INNER JOIN employees e2 On E1.ReportsTo= E2.EmployeeID

   select e1.FirstName,e1.LastName,e2.firstname+' '+e2.LastName ReportsTo 
  from employees e1 LEFT JOIN employees e2 On E1.ReportsTo= E2.EmployeeID

  select * from shippers CROSS JOIN region

  ----------------------------------------------------------------------------------
  --INSERT
  select * from products
  insert into products(productname,unitprice,UnitsInStock)
  values('Yoghurt',4.50,49)

  select * from shippers
  insert into shippers values('Yurti�i Kargo','(212)222-2222')

  select * from employees
  insert into employees(LastName,FirstName,Title,BirthDate,City)
  values('G�ner','Aleyna','Student','1997-02-14','�stanbul')


  -----------------------------------------------------------------------
  --UPDATE

  select * from products
  update products set unitprice = 19 where ProductID=78

  --stokta 10dan azsa y�zde 10 zam yap
  update products set unitprice*=(1.1) where UnitsInStock<10
  
  --�i�eyle al�nan �r�nlerden 1 dolar ekle 
  update products set unitprice+=1 where QuantityPerUnit like '%bottle%'

  --�ehri london olanlar� istanbul �lkelerini tr yap
  select * from employees
  update Employees set city='�stanbul',country='T�rkiye' where city= 'london'

  -------------------------------------------------------------------------------
  --DELETE
  select * from Products
  delete from products where ProductID=80

  select * from EMPLOYEES
  delete from Employees where EmployeeID=11

  

