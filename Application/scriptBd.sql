--drop database GestionPaieRoyal
create database GestionPaieRoyal
go
use GestionPaieRoyal

create table profession
(
	id int identity,
	designation varchar(100),
	constraint pk_profession primary key(id),
	constraint uk_profession_designation unique(designation)
)
go

create table province
(
	id int identity,
	designation varchar(30),
	constraint pk_province primary key(id),
	constraint uk_province_designation unique(designation)
)
go

create table unite
(
	id int identity,
	designation varchar(100),
	constraint pk_unite primary key(id),
	constraint uk_unite_designation unique(designation)
)
go

create table implatation
(
	id int identity,
	designation varchar(100),
	constraint pk_implatation primary key(id),
	constraint uk_implatation_designation unique(designation)
)
go

create table garnison
(
	id int identity,
	designation varchar(100),
	constraint pk_garnison primary key(id),
	constraint uk_garnison_designation unique(designation)
)
go

create table grade
(
	id int identity,
	codegradepaie varchar(100),
	designation varchar(100),
	montant float,
	constraint pk_grade primary key(id),
	constraint uk_grade_codegradepaie unique(designation),
	constraint uk_grade_designation unique(codegradepaie)
)
go

create table cotitulairecompte
(
	id int identity,
	id_profession int,
	nom varchar(30),
	postnom varchar(40),
	prenom varchar(30),
	sexe varchar(1),
	etatcivil varchar(15),
	datenaissance datetime,
    lieunaissance varchar(100),
    nomPrenomPere varchar(100),
    nomprenomMere varchar(100),
    modeidentification varchar(40),
    numeropieceIdentite varchar(40),
    detelivresonpieceidentite datetime,
    nomemploiyer varchar(100),
    addresseemploiyer varchar(220),
    telbureau varchar(13),
    adressepostal varchar(30),
    ville varchar(40),
    pays varchar(40),
    nationalite varchar(40),
    nomconjoin varchar(40),
    prenomconjoin varchar(40),
    adressepostale varchar(40),
    email varchar(40),
    tel varchar(13),
    fax varchar(40),
	constraint pk_cotitulairecompte primary key(id),
	constraint fk_cotitulairecompte_id_profession foreign key(id_profession) references profession(id)
)
go

create table militaire
(
	id int identity,
	id_cotitulairecompte int,
	id_province int,
	id_unite int,
	id_garnison int,
	id_implatation int,
	id_grade int,
	numeroidentifiantUnique int,
	matricule int,
	nom varchar(30),
	postnom varchar(40),
	prenom varchar(30),
	sexe varchar(1),
	etatcivil varchar(15),
	datenaissance datetime,
    lieunaissance varchar(100),
    nomPrenomPere varchar(100),
    nomprenomMere varchar(100),
    modeidentification varchar(40),
    numeropieceIdentite varchar(40),
    detelivresonpieceidentite datetime,
    nomemploiyer varchar(100),
    addresseemploiyer varchar(220),
    telbureau varchar(13),
    adressepostal varchar(30),
    ville varchar(40),
    pays varchar(40),
    nationalite varchar(40),
    nomconjoin varchar(40),
    email varchar(40),
    tel varchar(13),
    fax varchar(40),
	constraint pk_militaire primary key(id),
	constraint fk_militaire_id_cotitulairecompte foreign key(id_cotitulairecompte) references cotitulairecompte(id),
	constraint fk_militaire_id_province foreign key(id_province) references province(id),
	constraint fk_militaire_id_unite foreign key(id_unite) references unite(id),
	constraint fk_militaire_id_garnison foreign key(id_garnison) references garnison(id),
	constraint fk_militaire_id_implatation foreign key(id_implatation) references implatation(id),
	constraint fk_militaire_id_grade foreign key(id_grade) references grade(id),
	constraint uk_militaire_numeroidentifiantUnique unique(numeroidentifiantUnique),
	constraint uk_militaire_matricule unique(matricule),
)
go

create table periode
(
	id int identity,
	moisperiode varchar(30),
	anneeperiode int,
	constraint pk_periode primary key(id),
	constraint uk_periode_moisperiode_anneeperiode unique(moisperiode,anneeperiode)
)
go

create table paiement
(
	id int identity,
	id_militaire int,
	id_periode int,
	typePaiement varchar(30),
	montant float,
	nombreJour int,
	datetimePaiement datetime,
	constraint pk_paiement primary key(id),
	constraint fk_paiement_id_militaire foreign key(id_militaire) references militaire(id),
	constraint fk_paiement_id_periode foreign key(id_periode) references periode(id)
)
go
