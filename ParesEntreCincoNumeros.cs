using System;

class ParesEntreCincoNumeros {
	static void Main(string[] args) {

		const int qtdRepeticoes = 5;
		int iterator = 1, somaPar = 0, entrada;
		while(iterator<=qtdRepeticoes) {
			entrada = int.Parse(Console.ReadLine());

			if (entrada%2==0)
				somaPar++;
			iterator++;
		}
		Console.WriteLine("{0} valores pares", somaPar);
	}
}
