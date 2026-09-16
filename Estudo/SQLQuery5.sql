CREATE TABLE Cidades (
    ID INT NOT NULL IDENTITY(1000, 1) PRIMARY KEY,
    cidade VARCHAR(50) NOT NULL,
    idEstado INT NOT NULL,
    ddd VARCHAR(4) NULL
);

INSERT INTO Cidades (cidade, ddd, idEstado) 
VALUES 
('Foz', '45', 200),
('Curitiba', '41', 200),
('Joinville', '47', 201);

ALTER TABLE Cidades 
ADD CONSTRAINT FK_CIDADES_IDESTADO 
FOREIGN KEY (idEstado) REFERENCES Estados(ID);

SELECT * FROM Cidades;

SELECT c.ID, c.cidade, c.ddd, c.idEstado 
FROM Cidades c;

SELECT c.ID, c.cidade, c.ddd, c.idEstado, e.estado, e.uf 
FROM Cidades c
INNER JOIN Estados e ON c.idEstado = e.id;