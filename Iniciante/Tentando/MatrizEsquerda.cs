using System;

class MatrizEsquerda {
	static void Entrada(double[,] c) {
		
		for(int i = 0; i<c.GetLength(0); i++) {
			for(int j = 0; j<c.GetLength(1); j++) {
				c[i,j] = double.Parse(Console.ReadLine());
			}
		}
	}

	static double CalculaMatriz(double[,] c, char caractere) {
	
		double soma = 0;
		int qtd = 0;

		for(int i = 1; i<6; i++) {
			for(int j = 0; j<i; j++) {
				soma = soma + c[i,j];
				qtd++;
			}
		}	
		for(int i = 6; i<c.GetLength(0)-1; i++) {
			for(int j = 0; j<5-(i-6); j++) {
				soma = soma + c[i,j];
				qtd++;
			}
		}	

		if (caractere=='S') return soma;
		else return soma/qtd;
	}

	static void Main(string[] args) {
	
		double[,] c = new double[12,12];

//		char carac = Console.ReadKey().KeyChar;
		
		Entrada(c);
		Console.WriteLine();
		Console.WriteLine(CalculaMatriz(c, 'S'));
	}
}
