USE Fac
/* ---------------------------------------------------------------------- */
/*                        Declaração de Variáveis                         */
/* ---------------------------------------------------------------------- */
DECLARE @I INT = 1;
DECLARE @ano INT;
DECLARE @sem INT;
DECLARE @J INT;
DECLARE @H INT = 1;
DECLARE @A TABLE (linha INT NOT NULL IDENTITY, sala1 INT, sala2 INT);
DECLARE @tabela1 TABLE(username INT,course1 VARCHAR(255),type1 INT, role1 VARCHAR(10), group1 VARCHAR(10))
DECLARE @X TABLE (id INT NOT NULL IDENTITY, tur VARCHAR);
DECLARE @Y TABLE (ser INT);
DECLARE @idNum1 VARCHAR(50);
DECLARE @idNum2 VARCHAR(50);
/* ---------------------------------------------------------------------- */

/* ---------------------------------------------------------------------- */
/*                           DEFINIR VALORES                              */
/* ---------------------------------------------------------------------- */

INSERT INTO @X (tur) VALUES ('A'),('B'),('C'),('D'),('E'),('F'),('G'),('H'),('I'),('J') -- Turmas que podem existir
INSERT INTO @A (sala1, sala2) VALUES (8720,8725),(8721,8726),(8722,8727),(8723,8728),(8724,8729),
										(8730,0),(8731,0),(8732,0),(8733,0),(8734,0),(8735,0),(8736,0),(8737,0),(8739,0) --Código das SAVs

SET @ano = YEAR(GETDATE()); -- Pega o ano automaticamente
SET @sem = '1'; -- Seleciona o semestre

/* ---------------------------------------------------------------------- */
WHILE @I <= (SELECT COUNT(linha) FROM @A)
BEGIN
	DECLARE @cod_disc1 INT = (SELECT sala1 FROM @A WHERE linha = @I);
	DECLARE @cod_disc2 INT = (SELECT sala2 FROM @A WHERE linha = @I);
	DECLARE @tur1 CHAR;
	DECLARE @tur2 CHAR;
		IF (@cod_disc2 <> 0)
		BEGIN
			SET @J = 1;
			WHILE @J < 10
			BEGIN
				SET @idNum1 = '';
				SET @idNum2 = '';
				SET @tur1 = (SELECT tur FROM @X WHERE id = @J);
				SET @tur2 = (SELECT tur FROM @X WHERE id = (@J + 1));
				SET @idNum1 = (SELECT CONCAT(@ano,';',@sem,';30;',@cod_disc1,'_9',@tur1,'_10',@tur1,';',@cod_disc2,'_9',@tur2,'_10',@tur2));
				SET @idNum2 = (SELECT CONCAT(@ano,';',@sem,';30;',@cod_disc1,'_9',@tur2,'_10',@tur2,';',@cod_disc2,'_9',@tur1,'_10',@tur1));
				INSERT INTO @tabela1 (username,course1,type1,role1, group1) 
				SELECT DISTINCT m.codigo_aluno,
							mc.shortname,
							1,
							'student',
							CONCAT('turma ',m.serie, m.turma)
						FROM Fac.dbo.matricula m

						INNER JOIN Fac.dbo.aluno a
							ON m.codigo_aluno = a.codigo_aluno
							AND m.ano = a.ano_aluno
							AND m.semestre = a.semestre
						INNER JOIN Moodle_Acad.dbo.mdl_course mc
							ON mc.idnumber in (@idNum1, @idNum2)
						WHERE 
							(a.codigo_situacao_aluno = 1 AND a.ano_aluno = (CONCAT(@ano,@ano)) AND a.semestre = @sem AND a.codigo_curso = 30
							AND m.serie in ('9','10') AND m.turma in (@tur1,@tur2));
				SET @J += 2;
			END;
		END;
		ELSE
		BEGIN
			SET @J = 1;
			WHILE @J <= 10
			BEGIN
				SET @tur1 = (SELECT tur FROM @X WHERE id = @J); 
				SET @idNum1 = '';
				SET @idNum1 = CONCAT(@ano,';',@sem,';30;',@cod_disc1,'_11',@tur1,'_12',@tur1)
				INSERT INTO @tabela1 (username,course1,type1,role1, group1) 
				SELECT DISTINCT m.codigo_aluno,
							mc.shortname,
							1,
							'student',
							CONCAT('turma ', m.serie, m.turma)
						FROM Fac.dbo.matricula m
						INNER JOIN Fac.dbo.aluno a
							ON m.codigo_aluno = a.codigo_aluno
							AND m.ano = a.ano_aluno
							AND m.semestre = a.semestre
						INNER JOIN Moodle_Acad.dbo.mdl_course mc
							ON mc.idnumber = @idNum1
						WHERE 
							(a.codigo_situacao_aluno = 1 AND a.ano_aluno = (CONCAT(@ano,@ano)) AND a.semestre = @sem AND a.codigo_curso = 30
							AND m.serie in ('11','12') AND m.turma = @tur1);
				SET @J += 1;
			END;
		END;
	SET @I += 1;
END;

SELECT * FROM @tabela1

--(SELECT shortname FROM Moodle_Acad.dbo.mdl_course mc WHERE mc.idnumber LIKE @idNum)