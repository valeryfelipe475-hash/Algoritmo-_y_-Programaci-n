Algoritmo ControolVelocidad
	Definir velocidad Como Real;
	
	Escribir "Ingrese la velocidad registrada del vehiculo (km/h):";
	Leer  velocidad;
	
	Si velocidad > 80 Entonces
		Escribir "¡ALERTA! Ha superado el limite de velocidad de 80 km/h.";
		Escribir " Se ha generado  una fotomulta automatica.";
	FinSi
	
	Escribir  " Evaluacion de trancito finalizada.";
	
FinAlgoritmo
