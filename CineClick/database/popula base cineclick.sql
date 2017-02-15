use CineClick
go

INSERT INTO Filme
values(
	'e0a6679d-50cd-4190-8f84-e3b3bbe1416e',
	'Jogos Mortais',
	'Pessoas participam de jogos para sobreviver',
	GETDATE(),
	GETDATE()+10,
	'L',
	Getdate()
)

GO

INSERT INTO Sala
VALUES(
	'49dd717a-604d-4a3b-80ba-87604d1d8664',
	'SALA 10 - MAX 3D',
	260
)

GO


insert into programacao
values(
	'c1006f10-327d-45db-a928-03301bd74825',
	GETDATE(),
	GETDATE()+20
)

GO

INSERT INTO Sala
VALUES(
	'4d7d7b13-90b6-4e9a-9693-701ef99aae4D',
	'SALA 4',
	300
)

GO

insert into Sessao
values(
	'4d7d7b13-90b6-4e9a-9693-701ef99aae5d',
	'e0a6679d-50cd-4190-8f84-e3b3bbe1416e',
	'4d7d7b13-90b6-4e9a-9693-701ef99aae4D',
	 'c1006f10-327d-45db-a928-03301bd74825',
	0,
	1,
	 GETDATE()+1
)


