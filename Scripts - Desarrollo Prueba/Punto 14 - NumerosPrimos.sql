DROP TABLE IF EXISTS #NUMEROSPRIMOS
CREATE TABLE #NUMEROSPRIMOS(
	SECUENCIAL INT,
	VALOR INT
);


DECLARE @NUMEROEVALUAR INT
DECLARE @CONTADOR INT 
DECLARE @ESPRIMO BIT

DECLARE db_cursor CURSOR FOR (SELECT SECUENCIAL, VALOR FROM NUMEROS); 
			SET @NUMEROEVALUAR = @VALOR
			SET @CONTADOR = 2
			SET @ESPRIMO = 1

			WHILE ( @CONTADOR < @NUMEROEVALUAR )
				BEGIN
					IF @NUMEROEVALUAR % @CONTADOR = 0
						BEGIN
							SET @ESPRIMO = 0
							SET @CONTADOR = @NUMEROEVALUAR + 1
						END
					SET @CONTADOR  = @CONTADOR  + 1
				END

			IF @ESPRIMO = 1
				BEGIN
					INSERT INTO #NUMEROSPRIMOS(SECUENCIAL, VALOR) VALUES(@SECUENCIAL, @VALOR)
				END
		FETCH NEXT FROM db_cursor INTO @SECUENCIAL, @VALOR;

DELETE FROM #NUMEROSPRIMOS WHERE VALOR = 1


SELECT * FROM #NUMEROSPRIMOS