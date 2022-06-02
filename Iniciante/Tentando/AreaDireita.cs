using System;

class AreaDireita {

	static void CalculaMatriz(char[,] matriz) {
		
		int k = 0;
		for(int i = 1; i<matriz.GetLength(0)-1; i++) {
			for (int j = matriz.GetLength(1)-1; j>=matriz.GetLength(1)-1-k; j--) {
						matriz[i,j] = '*';
						k++;
			}
		}

		k = 5;

		for(int i = 6; i<matriz.GetLength(0)-1; i++) {
			for(int j = matriz.GetLength(1); j>matriz.GetLength(1)-k; j--) {
				matriz[i,j] = '*';
				k--;
			}
		}
	}

	static void ImprimeMatriz(char[,] matriz) {
		
		for(int i = 0; i<matriz.GetLength(0); i++) {
			for(int j = 0; j<matriz.GetLength(1); j++)
				Console.Write("{0} ", matriz[i,j]);
			Console.WriteLine();
		}
	}

	static void LeituraMatriz(double[,] matriz) {
		
//		Random aleatorio = new Random();

		for(int i = 0; i<matriz.GetLength(1); i++) {
			for(int j = 0; j<matriz.GetLength(0); j++) {
				matriz[i,j] = 3;
			}
		}
	}

	static void Main(string[] args) {
		
		const int lin = 12;
		const int col = 12;
	
		char[,] c = new char[lin, col];
		char opcao;

//		opcao = Console.ReadKey().KeyChar;
//		LeituraMatriz(c);
		CalculaMatriz(c);
		ImprimeMatriz(c);
//		Console.WriteLine("\n{0:0.0}", CalculaMatriz(c, opcao));
	}
}
