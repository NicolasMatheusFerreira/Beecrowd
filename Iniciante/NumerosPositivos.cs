using System;

class NumerosPositivos {
	static void Main(string[] args) {
		
		int cont = 1, qtdPositivo=0;
		double entrada;

		while (cont<=6.0) {
			entrada = double.Parse(Console.ReadLine()); // Entrada de valores

			if (entrada>0) {	// Processamento
				qtdPositivo++;
			}
			cont = cont + 1;
		}
		Console.WriteLine("{0} valores positivos", qtdPositivo); // Saída
	}
}
