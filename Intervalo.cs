using System;

class Intervalo {
	static void Main(string[] args) {
		double entrada = double.Parse(Console.ReadLine());

		if (entrada>=0.0 && entrada<=25.0) {
			Console.WriteLine("Intervalo [0,25]");
		} else if (entrada>=25.01 && entrada<=50.0) {
			Console.WriteLine("Intervalo (25,50]");
		} else if (entrada>=50.01 && entrada<=75.0) {
			Console.WriteLine("Intervalo (75,100]");
		} else if (entrada>=75.01 && entrada<=100.0) {
			Console.WriteLine("Intervalo (75,100]");
		} else Console.WriteLine("Fora de intervalo");
	}
}
