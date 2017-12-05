
SELECT Sintoma.Nombre_Sintoma FROM Sintoma
	JOIN Sintoma_Medicamento ON Sintoma_Medicamento.Id_Sintoma = Sintoma.Id_Sintoma
	JOIN Medicamento ON Sintoma_Medicamento.Id_Medicamento = Medicamento.Id_Medicamento
	
	WHERE Medicamento.Id_Medicamento = 19

	select * from Medicamento