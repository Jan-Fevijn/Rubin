Create Database if not exists Bakkerij;
use Bakkerij;

Create table if not exists brood(
	id int not null auto_increment,
    typeBrood varchar(45) not null,
    primary key(id)
);

Create table if not exists klant(
	idKlant int not null auto_increment,
	klantcode varchar(10) not null,
    naam varchar(45) not null,
    voornaam varchar(45) not null,
	dob date not null,
    Unique key(klantcode),
    primary key(idKlant)
);
Create table if not exists automaat(
	idAutomaat int not null auto_increment,
    locatie int not null,
    brood int not null,
    aantal int not null default 0,
    datum date,
    prijs decimal(10,2),
    primary key(idAutomaat),
    foreign key(brood) references brood(id)
);

Create table if not exists transactie(
	idTransactie int not null auto_increment,
    idAutomaat int not null,
    idKlant int not null,
    datum date,
    primary key(idTransactie),
    foreign key(idAutomaat) references automaat(idAutomaat),
    foreign key(idKlant) references klant(idKlant)
);

Create view transactieView as
Select automaat.idAutomaat, automaat.brood, automaat.prijs, transactie.idTransactie, transactie.datum
FROM transactie
Join automaat on transactie.idAutomaat = automaat.idAutomaat;

/* Triggers */
DELIMITER ;;
Create trigger automaat_datum_trigger
Before insert
	On automaat for each row
BEGIN
	SET NEW.datum = NOW();
END;;
DELIMITER ;

DELIMITER ;;
Create trigger transactie_datum_trigger
Before insert
	On transactie for each row
BEGIN
	SET NEW.datum = NOW();
END;;
DELIMITER ;
/* Inserts */

insert into brood(typeBrood) 
values
("Bus Limburgs Terf"),
("Bus Melkwit"),
("Bus Fijn Volkoren"),
("Bus Grof Volkoren"),
("Boeren Tarwe"),
("Bus Wit"),
("Bus Tarwe"),
("Boeren Donker Meergranen"),
("Bus Gogh Meergranen"),
("Bus Spelt (Half)"),
("Boeren Tijger Tarwe"),
("Boeren Tijger Wit"),
("Boeren Mout"),
("Herladen");

insert into klant(klantcode, naam, voornaam,dob)
values
("1234567894", "Paudel", "Rubin", 2002-10-12);
Insert into automaat(locatie, brood, prijs)
values
(001,1, 1.30),
(002,2, 2.30),
(003,3, 3.30),
(004,4, 4.30),
(005,5, 1.40),
(006,6, 1.60),
(007,7, 1.20),
(008,8, 1.90),
(009,9, 1.70),
(010,10, 2.30),
(011,11, 3.30),
(012,12, 1.30),
(013,13, 1.35)
;


/*
	Nog een Oplossing nodig om de saldo te kunnen herladen,
    en Prijs per Brood als de automaat niet wordt bijgevuld.
*/

