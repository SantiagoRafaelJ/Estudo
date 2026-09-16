CREATE TABLE Paises (
    ID INT NOT NULL IDENTITY(10, 1) PRIMARY KEY,
    pais VARCHAR(55) NOT NULL,
    sigla VARCHAR(3),
    ddi VARCHAR(4),
    moeda VARCHAR(4)
);

select *FROM Paises