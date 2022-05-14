using System;

class CarregaOuNaoCarrega {
	static void Main(string[] args) {
		
		string[] entrada = Console.ReadLine().Split();

		int valor1, valor2, resultado = 0;

		valor1 = int.Parse(entrada[0]);
		valor2 = int.Parse(entrada[1]);

		resultado = valor1+valor2;

		Console.WriteLine(resultado);
	}
}
