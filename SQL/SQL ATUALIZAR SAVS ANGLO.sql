--Declara as variáveis contadoras e as tabelas temporárias
DECLARE @salas TABLE (linha INT NOT NULL IDENTITY, sala INT);
DECLARE @nomes TABLE (linha INT NOT NULL IDENTITY, nome VARCHAR(100));
DECLARE @nomeSav VARCHAR(100);
DECLARE @i INT = 1;
DECLARE @j INT = 1;

--Insere na tabela @salas os IDs das salas de determinadas categorias
INSERT INTO @salas (sala)
	(SELECT DISTINCT (cfo.courseid)
	 FROM Moodle_Anglo.dbo.mbm_course_format_options cfo
	 INNER JOIN Moodle_Anglo.dbo.mbm_course c
	 ON c.id = cfo.courseid
	 WHERE category between 70 and 72)

--Insere na tabela @nomes os nomes das opções do formato do curso
INSERT INTO @nomes (nome)
	(SELECT DISTINCT (cfo.name)
	 FROM Moodle_Anglo.dbo.mbm_course_format_options cfo
	 INNER JOIN Moodle_Anglo.dbo.mbm_course c
	 ON c.id = cfo.courseid
	 WHERE cfo.courseid = '769')

--Começa o loop para cada opção do formato do curso
BEGIN TRANSACTION
WHILE @i <= (SELECT COUNT(linha) FROM @salas)
BEGIN
	SET @j = 1
	WHILE @j <= (SELECT COUNT(linha) FROM @nomes)
	BEGIN
		SET @nomeSav = (SELECT nome FROM @nomes WHERE linha = @j)
		UPDATE Moodle_Anglo.dbo.mbm_course_format_options
		--Começa o loop para cada sala da tabela @salas
			SET
				value = (SELECT value FROM Moodle_Anglo.dbo.mbm_course_format_options
						 WHERE courseid = '769' AND name LIKE @nomeSav)
			WHERE
				courseid = (SELECT sala FROM @salas WHERE linha = @i)
				AND name LIKE @nomeSav
		SET @j += 1
	END;
	SET @i += 1
END;

--Rollback
--Commit