select productname from products

select productname,unitprice from products

select productname,unitprice from products

seLect ProDuctName,UnitsInStock,unitPrice from products

--Yorum satýrý çift çift çizgiyle yapýlýr

select * from products

select * from products where UnitPrice = 18

--stokta 10dan az olan ürünlerin isim ve stok miktarlarý
select productname,unitsýnstock from products where unitsýnstock<10

--ismi chai olan ürünü getir
select * from products where productname = 'chai'

--SELECT CONVERT 

select * from products where unitprice between 10 and 20
select * from products where unitprice >=10 and unitprice <=20

--2 numaralý katagori olacak birim fiyatý 20 ile 50 arasýnda
select * from products where categoryýd=2 and unitprice between 20 and 50

select * from products where CategoryID in (2,3,4)
select * from products where categoryId=2 or categoryId=3 or categoryId=4

--Londroda ve Seattle da yaþayanlarý in ile
select * from employees where city in ('london','seattle')
--olmadýklarýný göstermek için 
select * from employees where city not in ('london','seattle')

select * from customers where fax is null

select * from customers where fax is not null

--ilk karakter c geri kalaný farketmez
select * from products where productname like 'c%'

--c ile bitenler
select * from products where productname like '%c'

--c ile baþlayýp h ile biten
select * from products where productname like 'c%h'

--herhangi bir yerinde c olmasý 
select * from products where productname like '%c%'

--c ile baþlayýp herhangi bir yerinde h olan 
select * from products where productname like 'c%h%'

--Öncesine tek karakter gelmesi demek
select * from products where productname like '_h%'

--c ile baþlayýp 3 karakter daha alan
select * from products where productname like 'c___'

--c ile baþlayýp en az 4 karakterli olcak
select * from products where productname like 'c____%'

--iki kelimeden oluþsun
select * from products where productname like '% %'

--þiþe ile satýlan ürünler
select * from products where QuantityPerUnit like '%bottle%'

--ilk karakteri c ya da a olan
select * from products where productname like '[ca]%'

--ilk karakteri c ikincisi h ya da a olan 
select * from products where productname like 'c[ha]%'

--a b c d den biri ile baþlayan demek
select * from products where productname like '[a-d]%'
select * from products where productname like '[abcd]%' --birbirleri ile ayný

--içinde rakam geçen ürünler
select * from products where productname like '%[0-9]%'

--ilk harfi c olmayan ürünler
select * from products where productname like '[^c]%'

--c ile baþlayan ikinci harfi h ya da g olmayan ürünler
select * from products where productname like 'c[^hg]%'

--herhangi bir yerinde c olmayan :)))
select * from products where productname like '%[^c]%'

--içinde c geçmeyen 
select * from products where productname not like '%c%'

--UnitsInStock'a göre sýrala
select * from products order by UnitsInStock 
select * from products order by UnitsInStock,productname 
--eðer aynýysa productname e göre sýrala dedik

select * from products order by unitprice DESC

--þiþeyle satýlan ürünleri pahalýdan ucuza dizin
select * from products where QuantityPerUnit like '%bottle%' order by UnitPrice DESC

--Hangi ülkelerde müþteri olduðunu bulucaz birbirinden farklýlarý getirmeli tabiki
select distinct country from customers
--tek sütunlu kullanýmý daha çok mantýklý 

select top 5 * from products order by unitprice desc

select top 5 percent * from products order by unitprice desc

select top 3 with ties * from products order by UnitsInStock

select productname,UnitsInStock,UnitPrice from products
--Çarpýmlarýyla yeni sütun oluþturduk
select productname,UnitsInStock*UnitPrice from products order by UnitsInStock*UnitPrice desc

--ünvan isim soyad olarak tek bir sütunda görmek istiyoruz
select TitleOfCourtesy+' '+FirstName+' '+LastName from employees

--yeni sütuna isim verme iþlemi
select TitleOfCourtesy+' '+FirstName+' '+LastName as 'FullName' from employees

--isim deðiþtirme
select productname as 'ürün' from products
--sql için özel bir anlamý yoksa where from vs gibi tek týrnak koymaya gerek yok
select productname as ürün from products
--as de konulmayabiliyor arada virgül yoksa 
select productname ürün from products

--FONKSÝYONLAR

--1)COUNT
select COUNT(productname) ADET from products
--adet adýnda sütunda kaç tane isim olduðunu göterir iþlem yapmak için count lazým
select COUNT(unitprice) ADET from products
select COUNT(*) ADET from products

select COUNT(companyname) from customers
select COUNT(contactname) from customers
select COUNT(*) from customers
select COUNT(fax) from customers
--fax için null deðerleri saymadý

--birbirinden farklý kaç ülkeye satýþ yapýyorum
select COUNT(distinct country) from customers

--berlinde yaþayan ve fax numarasý olan kaç müþteri var
select count(*) from customers where city='berlin' and fax is not null

--2)SUM
select SUM(unitsInstock) from products

--depoda ne kadarlýk mal var
select SUM(UnitsInStock*UnitPrice) TOPLAM from products

--özel isim order olduðu için birde iki kelimeden oluþtuðu için köþeli karakter
select * from [Order Details] 

--Ýndirimleri ekledikten sonra kasaya giren toplam para
select SUM((unitprice*quantity)*(1-discount)) from [Order Details]

--51 numaralý ürünlerin satýþýnda toplam kaç dolar indirim
select Round(Sum(UnitPrice*Quantity*discount),0) from [Order Details] where ProductID=51

select FORMAT(123456789,'#,0.00')

select Sum(UnitPrice*Quantity*discount) from [Order Details]