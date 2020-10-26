Create Database Sinema
GO
Use Sinema
GO
Create Table Salon(
SaID int IDENTITY,
SaNo nvarchar(255) NOT NULL)

Create Table Film(
FiID int IDENTITY,
FiAd nvarchar(255) NOT NULL)

Create Table Seans(
SeID int IDENTITY,
FilmID int NOT NULL,
SalonID int NOT NULL,
Saat nvarchar(5))

Create Table SatýnAlma(
StID int IDENTITY,
SeansID int NOT NULL,
Fiyat money,
KoltukNo int NOT NULL)

Insert Into Salon(SaNo)
Values ('Salon1')

Insert Into Salon(SaNo)
Values ('Salon2')

Insert Into Film(FiAd)
Values ('Prestij')

Insert Into Film(FiAd)
Values ('Aslan Kral')

select * from salon 
select * from film

Insert Into Seans(FilmID,SalonID,Saat)
Values(1,1,'15.00')


