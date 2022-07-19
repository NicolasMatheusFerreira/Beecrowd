using System;

class RespostaCerta {
	
	static void Main(string[] args) {
		
		int qtdQuestoes;		

		qtdQuestoes = int.Parse(Console.ReadLine());

		int[] resposta = new int[qtdQuestoes];

		for(int i = 1; i<=qtdQuestoes; i++) {
			resposta[i-1] = int.Parse(Console.ReadLine());	
		}

		for(int y = 0; y<resposta.Length; y++) {
			Console.WriteLine($"resposta {y+1}: {resposta[y]}");
		}
	}
}
