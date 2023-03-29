create database sklep_elektroniczny
use sklep_elektroniczny
create table produkt (id int primary key identity(1,1),nazwa varchar(30) not null,model varchar(30) not null,opis varchar(100),ilosc_dostepna int not null,cena decimal not null,unique(nazwa,model))
create table zamowienie (id int primary key identity(1,1), numer_zamowienia char(8) not null unique, data_zamowienia date not null)
create table kategoria (id int primary key identity(1,1), kategoria varchar(30) not null)
create table produkt_kategoria (id int primary key identity(1,1), id_produkt int foreign key references produkt(id) not null,id_kategoria int foreign key references kategoria(id) not null)
create table zamowienie_produkt (id int primary key identity(1,1), id_produkt int foreign key references produkt(id) not null,id_zamowienie int foreign key references zamowienie(id) not null, ilosc int not null, cena money not null)

insert into produkt values ('samsung','galaxy s21',null,0,2000)
insert into produkt values ('samsung','galaxy s23 ultra','256 gb',5,7000)
insert into produkt values ('apple','iphone 14 pro max','1 tb',2,11000)
insert into produkt values ('apple','iphone 14','128 gb',4,4000)
	
insert into kategoria values ('android')
insert into kategoria values ('ios')

insert into zamowienie values ('2023/001','2023-03-01')
insert into zamowienie values ('2023/002','2023-03-16')

insert into produkt_kategoria values (1,1)
insert into produkt_kategoria values (2,1)
insert into produkt_kategoria values (3,2)
insert into produkt_kategoria values (4,2)

insert into zamowienie_produkt values (3,1,1,11000)
insert into zamowienie_produkt values (4,1,2,8000)
insert into zamowienie_produkt values (2,2,3,21000)

create view products_view as 
SELECT produkt.id, produkt.nazwa, produkt.model, kategoria.kategoria, produkt.ilosc_dostepna, produkt.cena
FROM produkt_kategoria INNER JOIN produkt ON produkt.id = produkt_kategoria.id_produkt
INNER JOIN kategoria ON kategoria.id = produkt_kategoria.id_kategoria

create view orders_view as
SELECT zamowienie.id, zamowienie.numer_zamowienia, ISNULL(SUM(zamowienie_produkt.cena), 0) AS suma_sprzedazy, zamowienie.data_zamowienia
FROM zamowienie LEFT OUTER JOIN zamowienie_produkt ON zamowienie.id = zamowienie_produkt.id_zamowienie
GROUP BY zamowienie.id, zamowienie.numer_zamowienia, zamowienie.data_zamowienia

create view orderitems_view as
SELECT zamowienie_produkt.id,zamowienie.numer_zamowienia, produkt.nazwa, produkt.model, zamowienie_produkt.ilosc,zamowienie_produkt.cena
FROM zamowienie_produkt inner JOIN produkt ON produkt.id = zamowienie_produkt.id_produkt
inner join zamowienie on zamowienie_produkt.id_zamowienie = zamowienie.id
