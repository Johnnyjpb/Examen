/*CREATE DATABASE BookContactDatabase;
GO
USE BookContactDatabase;
GO
CREATE TABLE TYPECONTACT(
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(35) NOT NULL
);
GO
CREATE TABLE MARITALSTATUS(
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(35) NOT NULL
);
GO
CREATE TABLE SEXUALITY(
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(35) NOT NULL
);
GO
CREATE TABLE CONTACTS(
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(35) NOT NULL,
Phone VARCHAR(25),
Cellphone VARCHAR(25) NOT NULL,
Birthdate DATE NOT NULL,
Fk_TypeContact INT NOT NULL,
Fk_MaritalStatus INT NOT NULL,
Fk_Sexuality INT NOT NULL,
FOREIGN KEY(Fk_TypeContact) REFERENCES TYPECONTACT(Id),
FOREIGN KEY(Fk_MaritalStatus) REFERENCES MARITALSTATUS(Id),
FOREIGN KEY(Fk_Sexuality) REFERENCES SEXUALITY(Id)
);
GO*/

/*INSERT INTO TYPECONTACT VALUES ('FAMILIAR'), ('AMISTAD'), ('TRABAJO');
INSERT INTO MARITALSTATUS VALUES ('CASADO'), ('SOLTERO'), ('VIUDO'), ('DIVORCIADO'), ('UNION LIBRE')
INSERT INTO SEXUALITY VALUES ('MASCULINO'), ('FEMENINO')*/

/*CREATE PROCEDURE getContacts 
AS
BEGIN
SELECT * FROM CONTACTS;
END

EXEC getContacts*/

/*GIT ADD .
GIT COMMIT -M "EXAMENES"
GIT PUSH ORIGIN HU-LuisMoises*/