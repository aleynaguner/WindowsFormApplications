INSERT INTO [Order Details](ORDERID,PRODUCTID,unitprice,Quantity,Discount)
VALUES (10248,1,9,10,0.5)

Insert Into [Order Details]
Values(10248,2,11,10,0)

update [Order Details] set Discount =0.1
where orderID=10248 and productID=1

select * from [Order Details]

-------------------------------------------------------------------------------------------
--DDL--------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------------

Create Database ilk
Go
Use ilk
Go

Create Table ogrenci(
ogrenci_no char(11),
isim nvarchar(255),
d_tarihi datetime,
adres nvarchar(255),
telefon char(11))

Create Table bolum(
bismi nvarchar(255),
bId int IDENTITY,
btelefon char(11),
badres nvarchar (255))

Create Table fakulte(
fismi nvarchar(255)Not Null,
fId char(11),
ftelefon char(11),
fadres nvarchar(255))
Go
Alter Table ogrenci
Add bolum_id char(11)
Go
Alter Table bolum
Add fakulte_id char(11)
Go
Alter Table fakulte
Drop Column ftelefon

-----------------------------------------------------------------------------------
----------------------------------SUPERMARKET--------------------------------------
-----------------------------------------------------------------------------------

Create Database Supermarket
Go
Use Supermarket

Create Table Urun
(
urunID int IDENTITY,
urunAdi nvarchar(255) not null,
urunFiyati money not null,
urunStok int,
kategoriID int,
tedarikciID int
)

Create Table Calisan
(
calisanID int IDENTITY,
calisanAdi nvarchar(255) not null,
calisanTel char(11) not null,
calisanDT datetime not null,
calisanBaslangicT datetime not null,
calisanPozisyonID int,
)

Create Table Tedarikci
(
tedarikciID int IDENTITY,
sirketAdi nvarchar(255) not null,
sirketTel char(11) not null
)

Create Table Satis
(
satisID int IDENTITY,
satisT datetime not null,
kasiyerID int,
kasaNo int,
odemeTuruID int not null,
)

Create Table Satis_Detay
(
satisID int not null,
urunID int not null,
urunAdet int not null,
)

Create Table Kategoriler
(
kategoriID int IDENTITY,
kategariAdi nvarchar(255) not null
)

Create Table Pozisyon
(
pozisyonID int IDENTITY,
poziyonAdi nvarchar(255) not null
)

Create Table Odeme_Turu
(
odemeID int IDENTITY,
odemeTuru nvarchar(255) not null,
indirim decimal (3,2)
)

Alter Table Kategoriler
Add Constraint pk_kat Primary Key(kategoriID)

Alter Table Urun 
Add Constraint pk_urun Primary Key(urunID)

Alter Table Urun
Drop Constraint pk_urun 

Alter Table Calisan
Add Constraint pk_clsn Primary Key(calisanID)

Alter Table Odeme_Turu
Add Constraint pk_odeme Primary Key(odemeID)

Alter Table Satis 
Add Constraint pk_sts Primary Key(satisID)

Alter Table Tedarikci
Add Constraint pk_tdrk Primary Key(tedarikciID)

Alter Table Pozisyon 
Add Constraint pk_poz Primary Key(pozisyonID)

Alter Table Urun
Add Constraint fk_kat Foreign Key(kategoriID)
References Kategoriler(kategoriID)

Alter Table Urun 
Add Constraint fk_tdrk Foreign Key(tedarikciID)
References Tedarikci(tedarikciId) ON DELETE CASCADE

Alter Table calisan
Add Constraint fk_poz Foreign Key(calisanPozisyonID)
References Pozisyon(pozisyonID) ON DELETE SET NULL ON UPDATE CASCADE

Alter Table Satis
Add Constraint fk_ksyr Foreign Key(kasiyerID)
References Calisan(calisanID) ON DELETE SET NULL ON UPDATE SET NULL

ALTER TABLE Satis
Add Constraint fk_odemetur Foreign Key(odemeTuruID)
References Odeme_Turu(odemeID) --

Alter Table Satis_Detay
Add Constraint fk_sd Foreign Key(satisID)
References Satis(satisID) ON DELETE CASCADE

Alter Table Satis_Detay
Add Constraint fk_satisurun Foreign Key(urunID)
References Urun(urunID) 

Insert Into Kategoriler
Values  (8)

Insert Into Pozisyon(poziyonAdi)
Values('Kasiyer')

Insert Into Tedarikci(sirketAdi,sirketTel)
Values ('Bal A.Þ.',02163089549)

Insert Into Odeme_Turu(odemeTuru,indirim)
Values('Kredi Kartý',0)

Insert Into Calisan
Values('Aleyna Güner',05389840244,1997-02-14,06-05-2018,1)
--tarihleri yazamýyorum??

--Delete from Calisan where calisanID=1

select * from Calisan

Insert Into Satis
Values (23/12/2018,1,2,1)

Alter Table Calisan
Add Constraint uk_tel UNIQUE(calisanTel)

Alter Table Tedarikci
Add Constraint uk_trkctel UNIQUE(sirketTel)

Alter Table Urun
Add Constraint c_fiyat CHECK(urunFiyati>=0)

Alter Table Urun
Add Constraint c_urunadi CHECK(urunFiyati like '[^Ðð]%')

select serverproperty('collation')

Alter Table Calisan
Add Constraint c_yas CHECK(calisanDT<getdate())

Alter Table Calisan
Add cinsiyet char(1)

Alter Table Calisan
--Add Constraint c_cins CHECK(cinsiyet ='M' OR cinsiyet='F')
Add Constraint c_cins CHECK(cinsiyet IN ('m','f'))

Alter Table Satis
Add Constraint d_satis DEFAULT(getdate()) for satisT

Alter Table Urun
Add Constraint d_stok DEFAULT(0) for urunStok

