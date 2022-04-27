using System;

class QuadradoDePares {
	static void Main(string[] args) {

		int cont = 2;
		int numero = int.Parse(Console.ReadLine());

		if (numero>5 && numero<2000) {
			while(cont<=numero) {
				Console.WriteLine("{0}^{1} = {2}", cont, 2, Math.Pow(cont,2));
				cont = cont + 2;
			}
		}
	}
}
