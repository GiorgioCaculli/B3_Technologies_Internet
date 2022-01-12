IF EXISTS (SELECT * FROM sysobjects WHERE name='sessions' and xtype='U')
DROP TABLE sessions;

IF EXISTS (SELECT * FROM sysobjects WHERE name='personnes' and xtype='U')
DROP TABLE personnes;

IF EXISTS (SELECT * FROM sysobjects WHERE name='parcours' and xtype='U')
DROP TABLE parcours;

CREATE TABLE personnes(
                      identifiant INT IDENTITY PRIMARY KEY,
                      nom VARCHAR(50) NOT NULL,
                      prenom VARCHAR(50) NOT NULL,
);

CREATE TABLE parcours(
                         identifiant INT IDENTITY PRIMARY KEY,
                         nom VARCHAR(50) NOT NULL,
                         temps_marche_minutes INT NOT NULL,
                         temps_course_minutes INT NOT NULL
);

CREATE TABLE sessions(
                                  identifiant INT IDENTITY PRIMARY KEY,
                                  id_utilisateur INT FOREIGN KEY REFERENCES personnes(identifiant),
                                  id_parcours INT FOREIGN KEY REFERENCES parcours(identifiant),
                                  type_session VARCHAR(50) NOT NULL,
                                  temps_minutes INT NOT NULL
);
