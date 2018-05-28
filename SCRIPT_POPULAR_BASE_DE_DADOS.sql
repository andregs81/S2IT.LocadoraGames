/*Inserindo os Amigos*/
SET IDENTITY_INSERT Amigo ON
go
insert into Amigo(AmigoId, Nome, Sobrenome,  Apelido, Celular)
values(1, 'João', 'de Souza Campos', 'Jão', '14981215599')
go
insert into Amigo(AmigoId, Nome, Sobrenome,  Apelido, Celular)
values(2, 'Mario', 'da Silva', 'Mario', '17981103932')
go
insert into Amigo(AmigoId, Nome, Sobrenome,  Apelido, Celular)
values(3, 'Clara', 'dos Anjos', 'Clarinha', '21988152388')
go
insert into Amigo(AmigoId, Nome, Sobrenome,  Apelido, Celular)
values(4, 'Patricia', 'Melo Lima', 'Paty', '19991258877')
go
SET IDENTITY_INSERT Amigo OFF
GO

/*Inserindo os Jogos*/
SET IDENTITY_INSERT Jogos ON
go
insert into Jogos(JogoId, Titulo, DataEmprestimo, AmigoId)
values(1, 'Mortal Kombat IV Complete Edition', null, null)
go
insert into Jogos(JogoId, Titulo, DataEmprestimo, AmigoId)
values(2, 'Super Mario Kart', '2018-05-01', 4)
go
insert into Jogos(JogoId, Titulo, DataEmprestimo, AmigoId)
values(3, 'Counter Strike', '2017-12-25', 1)
go
insert into Jogos(JogoId, Titulo, DataEmprestimo, AmigoId)
values(4, 'Fifa 2018', null, null)
go
insert into Jogos(JogoId, Titulo, DataEmprestimo, AmigoId)
values(5, 'Minecraft', '2018-01-01', 3)
go
insert into Jogos(JogoId, Titulo, DataEmprestimo, AmigoId)
values(6, 'Forza Horizon', null, null)
go
SET IDENTITY_INSERT Jogos OFF
