-- DML

USE WISHLISTS;
GO

INSERT INTO Usuarios(nickname, email, senha)
VALUES ('luqonhas', 'lucas@email.com', 'lucas132'), ('saulomsantos', 'saulo@email.com', 'saulo132');
GO

INSERT INTO Desejos(idUsuario, descricao, dataCriacao, favorito)
VALUES (1, 'Terminar esse projeto!', '27-05-2021', 0), (2, 'Tirar férias!', '27-05-2021', 1);
GO