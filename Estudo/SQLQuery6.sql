CREATE TABLE Funcionarios (
    ID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    numcnh VARCHAR(20) NOT NULL,
    datCnh VARCHAR(8) NOT NULL,
    mat VARCHAR(10) NOT NULL,
    salBase DECIMAL(10,2) NOT NULL,
    idCidade INT NOT NULL,
    numDep VARCHAR(15) NOT NULL,
    dataValidade DATE NOT NULL,
    cep VARCHAR(9) NOT NULL,
    idCargo INT NOT NULL
);

INSERT INTO Funcionarios (numcnh, datCnh, mat, salBase, idCidade, numDep, dataValidade, cep, idCargo)
VALUES 
('123456789', '20270101', '1001', 2500.00, 1, '2', '2027-01-01', '80000-000', 1),
('987654321', '20280510', '1002', 3200.00, 1, '0', '2028-05-10', '81000-100', 2),
('456123789', '20261220', '1003', 4100.00, 2, '3', '2026-12-20', '82000-200', 1);

ALTER TABLE Funcionarios ADD CONSTRAINT FK_FUNCIONARIOS_IDCIDADE FOREIGN KEY (idCidade) REFERENCES Cidades(id);
ALTER TABLE Funcionarios ADD CONSTRAINT FK_FUNCIONARIOS_IDCARGO FOREIGN KEY (idCargo) REFERENCES Cargos(codigo);

SELECT * FROM Funcionarios;

SELECT 
    f.ID,
    f.mat,
    f.numcnh,
    f.salBase,
    c.cidade AS NomeCidade, 
    cg.nomeCargo AS NomeCargo
FROM Funcionarios f
INNER JOIN Cidades c ON f.idCidade = c.id
INNER JOIN Cargos cg ON f.idCargo = cg.codigo;