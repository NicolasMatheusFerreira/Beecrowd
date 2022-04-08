using System;

class Multiplos {
	static void Main(string[] args) {
		int a, b;
		string[] entrada = Console.ReadLine().Split();

		a = int.Parse(entrada[0]);
		b = int.Parse(entrada[1]);

		if (a>b) {
			if (a%b==0) {
				Console.WriteLine("Sao Multiplos");
			} else Console.WriteLine("Nao sao Multiplos");
		} else if (b%a==0) {
			Console.WriteLine("Sao Multiplos");
		} else Console.WriteLine("Nao sao Multiplos");
	}
}
