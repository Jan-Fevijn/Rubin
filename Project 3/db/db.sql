Create Database if not exists Bakkerij;
use Bakkerij;

Create table if not exists brood(
	id int not null auto_increment,
    typeBrood varchar(45) not null,
    prijs decimal(10,2) not null,
    primary key(id)
);

Create table if not exists klant(
	klantcode int not null,
    naam varchar(45) not null,
    voornaam varchar(45) not null,
    saldo decimal(10,2) not null,
	dob date not null,
    primary key(klantcode)
);

Create table if not exists stock(
	idBrood int,
    aantal int not null,
    foreign key(idBrood) references brood(id)
);
Create table if not exists transactie(
	id int not null,
    idBrood int,
    klantcode int,
    foreign key(idBrood) references brood(id),
    foreign key(klantcode) references klant(klantcode)
);




/* Inserts */

insert into brood(typeBrood, prijs) 
values
("Bus Limburgs Terf", 2.90),
("Bus Melkwit", 3.10),
("Bus Fijn Volkoren", 2.80),
("Bus Grof Volkoren", 3.50),
("Boeren Tarwe", 2.90),
("Bus Wit", 1.80),
("Bus Tarwe", 2.90),
("Boeren Donker Meergranen", 2.20),
("Bus Gogh Meergranen", 2.80),
("Bus Spelt (Half)", 1.60),
("Boeren Tijger Tarwe", 2.70),
("Boeren Tijger Wit", 2.80),
("Boeren Mout", 3.80);

