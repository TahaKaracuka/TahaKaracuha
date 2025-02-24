-- Veritaban� yaratma operasyonu ba�l�yor
use master
go

if DB_ID('PortfolioDb') is not null
begin
	alter database PortfolioDb set single_user with rollback immediate
	drop database PortfolioDb
end
go

create database PortfolioDb collate Turkish_CI_AS
go

use PortfolioDb
go
--Veritaban� yaratma operasyonu sona erdi

--Uygulaman�n genel ayarlar� i�in Settings tablosu olu�turuluyor
create table Settings(
	Id int default 1,

	SiteName nvarchar(MAX) not null,
	FooterText nvarchar(MAX) not null,

	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

insert into Settings(SiteName,FooterText)
values
	(
		'Umay Erg�l',
		'Copyright � 2024 T�m hakklar� sakl�d�r | Bu site Colorlib Satner �ablonu ile haz�rlanm��t�r.'
	)
go

--Contacts tablosu olu�turuluyor
create table Contacts(
	Id int default 1,

	Address nvarchar(MAX) not null,
	PhoneNumber nvarchar(MAX) not null,
	Email nvarchar(MAX) not null,
	GoogleMap nvarchar(MAX) not null,

	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

insert into Contacts(Address,PhoneNumber,Email,GoogleMap)
values
	(
		'Kemanc� Selim A�a Cd. No:4/5 Kad�k�y/�stanbul',
		'555-789-56-42',
		'info@umayergul.com',
		'<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3008.095105412389!2d28.99570407551702!3d41.06691371581312!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7913b7b9b3f%3A0x154c9d69c759851e!2zSW5mb3RlY2ggQWNhZGVteSBZYXrEsWzEsW0gS3Vyc3UgKMWeacWfbGkvTWVjaWRpeWVrw7Z5IMWedWJlKQ!5e0!3m2!1str!2str!4v1732275986243!5m2!1str!2str" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>'
	)
go

--Abouts tablosu olu�turuluyor
create table Abouts(
	Id int default 1,

	AboutTitle nvarchar(MAX) not null,
	AboutText nvarchar(MAX) not null,
	AboutCvUrl nvarchar(MAX) not null,
	AboutImageUrl nvarchar(MAX) not null,

	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

insert into Abouts(AboutTitle,AboutText,AboutCvUrl,AboutImageUrl)
values
	(
		'Ben Kimim?',
		'Ben InfoTech Academy Yaz�l�m Uzmanl��� E�itimini tamamlad�m. �e�itli projelerde yer ald�m. Halihaz�rda dotnet ekosisteminde uygulama geli�tiriyorum. Ve bal�k tutmay� �ok seviyorum.',
		'files/aysenumayergulcv.pdf',
		'ui/img/about-us.png'
	)
go

--HomeBanners tablosu olu�turuluyor
create table HomeBanners(
	Id int default 1,

	HomeBannerTitle nvarchar(MAX) not null,
	HomeBannerSubTitle nvarchar(MAX) not null,
	HomeBannerText nvarchar(MAX) not null,
	HomeBannerImageUrl nvarchar(MAX) not null,

	CreatedAt datetime2(3) not null default getdate(),
	UpdatedAt datetime2(3)
)
go

insert into HomeBanners(HomeBannerTitle,HomeBannerSubTitle,HomeBannerText,HomeBannerImageUrl)
values
	(
		'Merhaba',
		'Ben Ay�en Umay Erg�l',
		'Senior DotNet Developer',
		'ui/img/banner/home-right.png'
	)
go



