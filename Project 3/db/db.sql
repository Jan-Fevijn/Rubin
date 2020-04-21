Create Database if not exists Bakkerij;
use Bakkerij;

Create table if not exists brood(
	id int not null auto_increment,
    broodCode int not null,
    typeBrood varchar(45) not null,
    prijs decimal(10,2) not null,
    aantal int default 0,
    primary key(id)
);

Create table if not exists klant(
	klantcode varchar(10) not null,
    naam varchar(45) not null,
    voornaam varchar(45) not null,
    saldo decimal(10,2) not null,
	dob date not null,
    primary key(klantcode)
);

Create table if not exists transactie(
	id int not null,
    idBrood int,
    klantcode varchar(10),
    foreign key(idBrood) references brood(id),
    foreign key(klantcode) references klant(klantcode)
);




/* Inserts */

insert into brood(typeBrood, prijs, broodCode) 
values
("Bus Limburgs Terf", 2.90,123),
("Bus Melkwit", 3.10,456),
("Bus Fijn Volkoren", 2.80,478),
("Bus Grof Volkoren", 3.50,365),
("Boeren Tarwe", 2.90,478),
("Bus Wit", 1.80,444),
("Bus Tarwe", 2.90,333),
("Boeren Donker Meergranen", 2.20,1234),
("Bus Gogh Meergranen", 2.80,784),
("Bus Spelt (Half)", 1.60,789),
("Boeren Tijger Tarwe", 2.70,987),
("Boeren Tijger Wit", 2.80,101),
("Boeren Mout", 3.80,102);

insert into klant(klantcode, naam, voornaam, saldo,dob)
values
("1234567894", "Paudel", "Rubin", 10.60, 2020-10-12)