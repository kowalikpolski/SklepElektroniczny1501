create table produkt (id int primary key,nazwa varchar(30) not null,model varchar(30) not null,opis varchar(100),ilosc_dostepna int not null,cena decimal not null,unique(nazwa,model))
create table zamowienie (id int primary key, numer_zamowienia char(8) not null unique, data_zamowienia date not null)
create table kategoria (id int primary key, kategoria varchar(30) not null)
create table produkt_kategoria (id int primary key, id_produkt int foreign key references produkt(id) not null,id_kategoria int foreign key references kategoria(id) not null)
create table zamowienie_produkt (id int primary key, id_produkt int foreign key references produkt(id) not null,id_zamowienie int foreign key references zamowienie(id) not null, ilosc int not null, cena money not null)

insert into produkt values (1,'samsung','galaxy s21',null,0,2000)
insert into produkt values (2,'samsung','galaxy s23 ultra','256 gb',5,7000)
insert into produkt values (3,'apple','iphone 14 pro max','1 tb',2,11000)
insert into produkt values (4,'apple','iphone 14','128 gb',4,4000)

insert into kategoria values (1,'android')
insert into kategoria values (2,'ios')

insert into zamowienie values (1,'2023/001','2023-03-01')
insert into zamowienie values (2,'2023/002','2023-03-16')

insert into produkt_kategoria values (1,1,1)
insert into produkt_kategoria values (2,2,1)
insert into produkt_kategoria values (3,3,2)
insert into produkt_kategoria values (4,4,2)

insert into zamowienie_produkt values (1,3,1,1,11000)
insert into zamowienie_produkt values (2,4,1,2,8000)
insert into zamowienie_produkt values (3,2,2,3,21000)
