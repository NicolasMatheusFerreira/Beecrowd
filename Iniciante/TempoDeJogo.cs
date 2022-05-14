using System;

class TempoDeJogo {
	static void Main(string[] args) {
		
		string[] entrada = Console.ReadLine().Split();

		int inicio = 0, fim = 0, duracao = 0;

		inicio = int.Parse(entrada[0]);
		fim = int.Parse(entrada[1]);

	 	if (inicio>fim) {
			duracao = 24-inicio+fim;
		} else if (fim>inicio){
			duracao = fim-inicio;
		} else duracao = 24;

		Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
	}
}
