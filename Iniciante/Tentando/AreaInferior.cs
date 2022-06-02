using System;

class AreaInferior {

	static double CalculaMatriz(double[,] matriz, char caracter) {
		
		int inic = 5, fim = 6, qtd = 0;
		double soma = 0;

		for(int i = 7; i<matriz.GetLength(0); i++) {
			for(int j = 1; j<matriz.GetLength(1); j++)
				if (j>=inic && j<=fim) {
					soma += matriz[i,j];
					qtd++;
				}
			
			inic--;
			fim++;
		}
	
		if (caracter=='S')
			return soma;
		else return soma/qtd;
	}

	static void ImprimeMatriz(double[,] matriz) {
		
		for(int i = 0; i<matriz.GetLength(0); i++) {
			for(int j = 0; j<matriz.GetLength(1); j++)
				Console.Write("{0} ", matriz[i,j]);
			Console.WriteLine();
		}
	}

	static void LeituraMatriz(double[,] matriz) {
		
//		Random aleatorio = new Random();

		int z = 1;
		for(int i = 0; i<matriz.GetLength(1); i++) {
			for(int j = 0; j<matriz.GetLength(0); j++) {
				matriz[i,j] = z++;
			}
		}
	}

	static void Main(string[] args) {
		
		const int lin = 12;
		const int col = 12;
	
		double[,] c = new double[lin, col];
		char opcao;

		opcao = Console.ReadKey().KeyChar;
		LeituraMatriz(c);
		Console.WriteLine("\n{0:0.0}", CalculaMatriz(c, opcao));
	}
}
