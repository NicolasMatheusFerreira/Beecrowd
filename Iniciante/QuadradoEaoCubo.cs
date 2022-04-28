using System;

class QuadradoEaoCubo {
	static void Main(string[] args) {
		
		int entrada;
		double cont = 1;

		entrada = int.Parse(Console.ReadLine());

		while(cont<=entrada) {
			Console.WriteLine("{0} {1} {2}", Math.Pow(cont,1), Math.Pow(cont,2), Math.Pow(cont,3));
			cont++;		
		}	
	}
}
