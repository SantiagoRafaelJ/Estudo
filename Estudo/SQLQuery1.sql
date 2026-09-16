CREATE TABLE Paises (
    ID INT NOT NULL IDENTITY(10, 1) PRIMARY KEY,
    pais VARCHAR(55) NOT NULL,
    sigla VARCHAR(3),
    ddi VARCHAR(4),
    moeda VARCHAR(4)
);

INSERT INTO Paises (pais, sigla, ddi, moeda)
VALUES ('BRASIL', 'BR', '+55', 'R$'),
       ('ESTADOS-UNIDOS', 'EUA', '+1', '$'),
       ('VENEZUELA', 'VEN', '+58', 'VES');

COMMIT;

select *FROM Paises;