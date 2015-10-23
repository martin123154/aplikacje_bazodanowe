

CREATE TABLE [zakup] (
  [zakup_id] int IDENTITY(1,1) NOT NULL,
  [zakup_data_zakupu] varchar(20) NULL,
  [zakup_klient_id] int NOT NULL REFERENCES klient(klient_id),
  PRIMARY KEY CLUSTERED ([zakup_id])
)



CREATE TABLE [premiera] (
  [premiera_id] int IDENTITY(1,1) NOT NULL,
  [premiera_tytul] varchar(40) NULL,
  [premiera_data_rozp] varchar(20) NULL,
  [premiera_data_zak] varchar(20) NULL,
  PRIMARY KEY CLUSTERED ([premiera_id])
)
GO
CREATE TABLE [bilet] (
  [bilet_id] int IDENTITY(1,1) NOT NULL,
  [bilet_cena] decimal(8,2) NULL,
  [bilet_rodzaj] varchar(20) NULL,
  [bilet_rzad] int NULL,
  [bilet_miejsce] int NULL,
   [bilet_premiera_id] int NOT NULL REFERENCES premiera(premiera_id),
   [bilet_zakup_id] int NOT NULL REFERENCES zakup(zakup_id),
  PRIMARY KEY CLUSTERED ([bilet_id])
)
GO



GO
 
 
CREATE TABLE [wystep] (
  [wystep_id] int IDENTITY(1,1) NOT NULL,
   [wystep_premiera_id] int NOT NULL REFERENCES premiera(premiera_id),
    [wystep_aktor_id] int NOT NULL REFERENCES aktor(aktor_id),
  PRIMARY KEY CLUSTERED ([wystep_id])
)
GO





