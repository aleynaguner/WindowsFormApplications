select productname from products

select productname,unitprice from products

select productname,unitprice from products

seLect ProDuctName,UnitsInStock,unitPrice from products

--Yorum sat�r� �ift �ift �izgiyle yap�l�r

select * from products

select * from products where UnitPrice = 18

--stokta 10dan az olan �r�nlerin isim ve stok miktarlar�
select productname,units�nstock from products where units�nstock<10

--ismi chai olan �r�n� getir
select * from products where productname = 'chai'

--SELECT CONVERT 

select * from products where unitprice between 10 and 20
select * from products where unitprice >=10 and unitprice <=20

--2 numaral� katagori olacak birim fiyat� 20 ile 50 aras�nda
select * from products where category�d=2 and unitprice between 20 and 50

select * from products where CategoryID in (2,3,4)
select * from products where categoryId=2 or categoryId=3 or categoryId=4

--Londroda ve Seattle da ya�ayanlar� in ile
select * from employees where city in ('london','seattle')
--olmad�klar�n� g�stermek i�in 
select * from employees where city not in ('london','seattle')

select * from customers where fax is null

select * from customers where fax is not null

--ilk karakter c geri kalan� farketmez
select * from products where productname like 'c%'

--c ile bitenler
select * from products where productname like '%c'

--c ile ba�lay�p h ile biten
select * from products where productname like 'c%h'

--herhangi bir yerinde c olmas� 
select * from products where productname like '%c%'

--c ile ba�lay�p herhangi bir yerinde h olan 
select * from products where productname like 'c%h%'

--�ncesine tek karakter gelmesi demek
select * from products where productname like '_h%'

--c ile ba�lay�p 3 karakter daha alan
select * from products where productname like 'c___'

--c ile ba�lay�p en az 4 karakterli olcak
select * from products where productname like 'c____%'

--iki kelimeden olu�sun
select * from products where productname like '% %'

--�i�e ile sat�lan �r�nler
select * from products where QuantityPerUnit like '%bottle%'

--ilk karakteri c ya da a olan
select * from products where productname like '[ca]%'

--ilk karakteri c ikincisi h ya da a olan 
select * from products where productname like 'c[ha]%'

--a b c d den biri ile ba�layan demek
select * from products where productname like '[a-d]%'
select * from products where productname like '[abcd]%' --birbirleri ile ayn�

--i�inde rakam ge�en �r�nler
select * from products where productname like '%[0-9]%'

--ilk harfi c olmayan �r�nler
select * from products where productname like '[^c]%'

--c ile ba�layan ikinci harfi h ya da g olmayan �r�nler
select * from products where productname like 'c[^hg]%'

--herhangi bir yerinde c olmayan :)))
select * from products where productname like '%[^c]%'

--i�inde c ge�meyen 
select * from products where productname not like '%c%'

--UnitsInStock'a g�re s�rala
select * from products order by UnitsInStock 
select * from products order by UnitsInStock,productname 
--e�er ayn�ysa productname e g�re s�rala dedik

select * from products order by unitprice DESC

--�i�eyle sat�lan �r�nleri pahal�dan ucuza dizin
select * from products where QuantityPerUnit like '%bottle%' order by UnitPrice DESC

--Hangi �lkelerde m��teri oldu�unu bulucaz birbirinden farkl�lar� getirmeli tabiki
select distinct country from customers
--tek s�tunlu kullan�m� daha �ok mant�kl� 

select top 5 * from products order by unitprice desc

select top 5 percent * from products order by unitprice desc

select top 3 with ties * from products order by UnitsInStock

select productname,UnitsInStock,UnitPrice from products
--�arp�mlar�yla yeni s�tun olu�turduk
select productname,UnitsInStock*UnitPrice from products order by UnitsInStock*UnitPrice desc

--�nvan isim soyad olarak tek bir s�tunda g�rmek istiyoruz
select TitleOfCourtesy+' '+FirstName+' '+LastName from employees

--yeni s�tuna isim verme i�lemi
select TitleOfCourtesy+' '+FirstName+' '+LastName as 'FullName' from employees

--isim de�i�tirme
select productname as '�r�n' from products
--sql i�in �zel bir anlam� yoksa where from vs gibi tek t�rnak koymaya gerek yok
select productname as �r�n from products
--as de konulmayabiliyor arada virg�l yoksa 
select productname �r�n from products

--FONKS�YONLAR

--1)COUNT
select COUNT(productname) ADET from products
--adet ad�nda s�tunda ka� tane isim oldu�unu g�terir i�lem yapmak i�in count laz�m
select COUNT(unitprice) ADET from products
select COUNT(*) ADET from products

select COUNT(companyname) from customers
select COUNT(contactname) from customers
select COUNT(*) from customers
select COUNT(fax) from customers
--fax i�in null de�erleri saymad�

--birbirinden farkl� ka� �lkeye sat�� yap�yorum
select COUNT(distinct country) from customers

--berlinde ya�ayan ve fax numaras� olan ka� m��teri var
select count(*) from customers where city='berlin' and fax is not null

--2)SUM
select SUM(unitsInstock) from products

--depoda ne kadarl�k mal var
select SUM(UnitsInStock*UnitPrice) TOPLAM from products

--�zel isim order oldu�u i�in birde iki kelimeden olu�tu�u i�in k��eli karakter
select * from [Order Details] 

--�ndirimleri ekledikten sonra kasaya giren toplam para
select SUM((unitprice*quantity)*(1-discount)) from [Order Details]

--51 numaral� �r�nlerin sat���nda toplam ka� dolar indirim
select Round(Sum(UnitPrice*Quantity*discount),0) from [Order Details] where ProductID=51

select FORMAT(123456789,'#,0.00')

select Sum(UnitPrice*Quantity*discount) from [Order Details]