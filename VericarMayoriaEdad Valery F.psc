Algoritmo VericarMayoriaEdad
	Escribir " ingrese el año actual:"   // Entrada
	Leer anioActual
	Escribir " Ingrese su año  de nacimiento:"
	Leer  anioNacimiento
	edad <- anioActual- anioNacimiento  // Proceso
	Si edad >= 19 Entonces               // Salida y logica
		Escribir "Es mayor de edad. Edad:", edad
	SiNo
		Escribir  " Es menor de edad . edad:", edad
	FinSi
FinAlgoritmo
