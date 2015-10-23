USE Dziennik
GO

DROP TABLE mar_osoba;
DROP TABLE mar_kraj;
DROP TABLE mar_miasto;
GO


CREATE TABLE [mar_miasto] (
  [mar_miasto_id] int IDENTITY(1,1) NOT NULL,
  [mar_miasto_nazwa] varchar(100) NULL,
  [mar_miasto_kod] varchar(100) NULL,
  PRIMARY KEY CLUSTERED ([mar_miasto_id])
)
GO


CREATE TABLE [mar_kraj] (
  [mar_kraj_id] int IDENTITY(1,1) NOT NULL,
  [mar_kraj_nazwa] varchar(100) NULL,
  [mar_kraj_kod] varchar(100) NULL,
  PRIMARY KEY CLUSTERED ([mar_kraj_id])
)
GO

CREATE TABLE [mar_osoba] (
  [mar_osoba_id] int IDENTITY(1, 1) NOT NULL,
  [mar_osoba_imie] varchar(100) NULL,
  [mar_osoba_nazwisko] varchar(100) NULL,
  [mar_osoba_mar_miasto_id] int NOT NULL REFERENCES mar_miasto(mar_miasto_id),
  [mar_osoba_mar_kraj_id] int NOT NULL REFERENCES mar_kraj(mar_kraj_id),
  [mar_osoba_zdjecie] image NULL,
  PRIMARY KEY CLUSTERED ([mar_osoba_id])
)
GO

INSERT INTO mar_miasto(mar_miasto_nazwa,mar_miasto_kod) VALUES('Malbork','11-222');
INSERT INTO mar_miasto(mar_miasto_nazwa,mar_miasto_kod) VALUES('Sopot','99-222');
INSERT INTO mar_miasto(mar_miasto_nazwa,mar_miasto_kod) VALUES('Gdynia','88-222');
GO

INSERT INTO mar_kraj(mar_kraj_nazwa,mar_kraj_kod) VALUES('Polska','PL');
INSERT INTO mar_kraj(mar_kraj_nazwa,mar_kraj_kod) VALUES('Stany Zjednoczone','USA');
GO

