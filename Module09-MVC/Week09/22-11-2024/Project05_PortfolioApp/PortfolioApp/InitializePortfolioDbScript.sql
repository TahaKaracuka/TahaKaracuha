-- Veritabaný yaratma operasyonu baþlýyor
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
--Veritabaný yaratma operasyonu sona erdi

--Uygulamanýn genel ayarlarý için Settings tablosu oluþturuluyor
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
		'Umay Ergül',
		'Copyright © 2024 Tüm hakklarý saklýdýr | Bu site Colorlib Satner þablonu ile hazýrlanmýþtýr.'
	)
go

--Contacts tablosu oluþturuluyor
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
		'Kemancý Selim Aða Cd. No:4/5 Kadýköy/Ýstanbul',
		'555-789-56-42',
		'info@umayergul.com',
		'<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3008.095105412389!2d28.99570407551702!3d41.06691371581312!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab7913b7b9b3f%3A0x154c9d69c759851e!2zSW5mb3RlY2ggQWNhZGVteSBZYXrEsWzEsW0gS3Vyc3UgKMWeacWfbGkvTWVjaWRpeWVrw7Z5IMWedWJlKQ!5e0!3m2!1str!2str!4v1732275986243!5m2!1str!2str" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>'
	)
go

--Abouts tablosu oluþturuluyor
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
		'Ben InfoTech Academy Yazýlým Uzmanlýðý Eðitimini tamamladým. Çeþitli projelerde yer aldým. Halihazýrda dotnet ekosisteminde uygulama geliþtiriyorum. Ve balýk tutmayý çok seviyorum.',
		'files/aysenumayergulcv.pdf',
		'ui/img/about-us.png'
	)
go

--HomeBanners tablosu oluþturuluyor
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
		'Ben Ayþen Umay Ergül',
		'Senior DotNet Developer',
		'ui/img/banner/home-right.png'
	)
go



