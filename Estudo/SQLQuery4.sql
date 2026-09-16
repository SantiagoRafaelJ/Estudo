CREATE TABLE Estados (
    ID INT NOT NULL IDENTITY(100, 1) PRIMARY KEY,
    estado VARCHAR(50) NOT NULL,
    uf VARCHAR(2) NOT NULL,
    idPais INT NOT NULL
);

INSERT INTO ESTADOS (estado, uf, idPais) 
VALUES ('Parana', 'PR', 10),
       ('Santa Catarina', 'SC', 10),
       ('Rio Grande do Sul', 'RS', 10);

ALTER TABLE ESTADOS 
ADD CONSTRAINT FK_ESTADOS_IDPAIS 
FOREIGN KEY (IDPAIS) REFERENCES Paises(ID);


SELECT * FROM Estados;

SELECT e.id, e.estado, e.uf, e.idPais 
FROM Estados e;

SELECT e.id, e.estado, e.uf, e.idPais, p.id, p.pais, p.ddi 
FROM Estados e
INNER JOIN Paises p ON e.idPais = p.id;