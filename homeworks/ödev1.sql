Create Database instagram
Go
Use instagram
Go 
Create Table kullanici(
kullaniciID int IDENTITY,
kullaniciIsmi nvarchar(255),
fotografID int,
mesajID text,
takipedilenID int,
takipciID int)

Create Table Fotograf(
fotografID int Identity,
fotograf image,
begeniID int,
tarih datetime,
yorumID int)

Create Table Mesaj(
mesajID int Identity,
yazanID int,
icerik text)

Create Table Takipci(
kullaniciID int,
kullaniciIsmi nvarchar(255))

Create Table TakipciEdilen(
kullan�c�ID int,
kullan�c�Ismi nvarchar(255))

Create Table Begeni(
fotografID int,
kullan�c�Ad� nvarchar(255))

Create Table Yorum(
fotografID int,
kullan�c�ID int,
kullan�c�Ad� nvarchar(255),
icerik text)
