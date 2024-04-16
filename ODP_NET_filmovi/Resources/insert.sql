Insert into ZANR (IDZ,NAZIVZ) values (10,'Naucno-fantasticni');
Insert into ZANR (IDZ,NAZIVZ) values (20,'Romanticni');
Insert into ZANR (IDZ,NAZIVZ) values (30,'Horor');
Insert into ZANR (IDZ,NAZIVZ) values (40,'Akcija');
Insert into ZANR (IDZ,NAZIVZ) values (50,'Komedija');
Insert into ZANR (IDZ,NAZIVZ) values (60,'Decji');
commit;

Insert into FILM (IDF,NAZIVF,ZANRF,TRAJANJEF,GODF) values (1,'Pokajanje',20,123,2007);
Insert into FILM (IDF,NAZIVF,ZANRF,TRAJANJEF,GODF) values (2,'Gordost i predrasude',20,129,2005);
Insert into FILM (IDF,NAZIVF,ZANRF,TRAJANJEF,GODF) values (3,'10 stvari koje mrzim o tebi',50,97,1999);
Insert into FILM (IDF,NAZIVF,ZANRF,TRAJANJEF,GODF) values (4,'Isterivaci duhova',10,105,1984);
Insert into FILM (IDF,NAZIVF,ZANRF,TRAJANJEF,GODF) values (5,'Grdana',10,97,2014);
Insert into FILM (IDF,NAZIVF,ZANRF,TRAJANJEF,GODF) values (6,'Hari Poter i kamen mudrosti',10,152,2001);
Insert into FILM (IDF,NAZIVF,ZANRF,TRAJANJEF,GODF) values (7,'Bela griva',60,47,1953);
Insert into FILM (IDF,NAZIVF,ZANRF,TRAJANJEF,GODF) values (8,'Sarlo kao bokser',50,33,1915);
commit;

Insert into KORISNIK (KORIMEK,IMEK,PRZK,POLK,AKTIVANK) values ('markovic.jovana','Jovana','Markovic','Z','y');
Insert into KORISNIK (KORIMEK,IMEK,PRZK,POLK,AKTIVANK) values ('petrovic.petar','Petar','Petrovic','M', 'y');
Insert into KORISNIK (KORIMEK,IMEK,PRZK,POLK,AKTIVANK) values ('patkica','Jelena','Krstic','Z', 'y');
Insert into KORISNIK (KORIMEK,IMEK,PRZK,POLK,AKTIVANK) values ('zabac','Lana','Vukovic','Z', 'y');
Insert into KORISNIK (KORIMEK,IMEK,PRZK,POLK,AKTIVANK) values ('pikacu','Marko','Ignjic','M', 'y');
commit;

Insert into OCENA (IDO,KORIMEO,FILMO,OCENAO,VAZECAO) values (1,'pikacu',1,3, 'y');
Insert into OCENA (IDO,KORIMEO,FILMO,OCENAO,VAZECAO) values (2,'pikacu',5,7, 'y');
Insert into OCENA (IDO,KORIMEO,FILMO,OCENAO,VAZECAO) values (3,'pikacu',3,8, 'y');
Insert into OCENA (IDO,KORIMEO,FILMO,OCENAO,VAZECAO) values (4,'patkica',1,8, 'y');
Insert into OCENA (IDO,KORIMEO,FILMO,OCENAO,VAZECAO) values (5,'patkica',2,5, 'y');
Insert into OCENA (IDO,KORIMEO,FILMO,OCENAO,VAZECAO) values (6,'patkica',6,10, 'y');
Insert into OCENA (IDO,KORIMEO,FILMO,OCENAO,VAZECAO) values (7,'zabac',5,6, 'y');
Insert into OCENA (IDO,KORIMEO,FILMO,OCENAO,VAZECAO) values (8,'petrovic.petar',1,10, 'y');
commit;