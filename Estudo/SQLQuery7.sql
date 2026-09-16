CREATE TABLE Cargo (
   ID INT NOT NULL IDENTITY(10, 1) PRIMARY KEY,
   exigeCNH BIT NOT NULL,
   comiss FLOAT NOT NULL,
   nome VARCHAR(25) NOT NULL
);

SELECT * FROM Cargo;

INSERT INTO Cargo (exigeCNH, comiss, nome)
VALUES 
(1, 0.0, 'Motorista'),
(0, 5.0, 'Vendedor'),
(0, 0.0, 'Analista');

SELECT * FROM Cargo;

SELECT c.ID, c.nome, c.exigeCNH, c.comiss 
FROM Cargo c;


SELECT c.ID, c.nome, c.exigeCNH, c.comiss
FROM Cargo c;