
USE Medicacion
/*---------------BUSCAR TODAS LAS ALERGIAS QUE TIENE UNA PERSONA------------------------*/
SELECT Componente.Id_Componente, Componente  
	FROM Componente 
		JOIN Alergia ON Alergia.Id_Componente = Componente.Id_Componente 
		JOIN Persona ON Alergia.Id_Persona = Persona.Id_Persona 
WHERE Persona.Id_Persona =2; 
/*---------------------------------------------------------------------------------------*/

/*--------------------BUSCAR LOS MEDICAMENTOS QUE SIRVAN PARA X SINTOMA-------------------------*/
SELECT Medicamento.Id_Medicamento, Medicamento.Nombre_Medicamento 
	FROM Medicamento 
		INNER JOIN Sintoma_Medicamento ON Sintoma_Medicamento.Id_Medicamento = Medicamento.Id_Medicamento
		INNER JOIN Sintoma ON Sintoma_Medicamento.Id_Sintoma = Sintoma.Id_Sintoma
WHERE Sintoma.Id_Sintoma = 1 ;

/*-------------------------BUSCAR MEDICAMENTOS QUE CONTENGAN X COMPONENTE-------------------------------*/
SELECT  Medicamento.Id_Medicamento, Medicamento.Nombre_Medicamento 
	FROM Medicamento
		INNER JOIN Composicion_Medicamento ON Composicion_Medicamento.Id_Medicamento = Medicamento.Id_Medicamento
		INNER JOIN Componente ON Composicion_Medicamento.Id_Componente = Componente.Id_Componente
WHERE NOT Componente.Id_Componente = 2