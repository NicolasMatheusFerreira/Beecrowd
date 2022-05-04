using System;

class Omaior {
	static void Main(string[] args) {
		
		string[] entrada = Console.ReadLine().Split();
		int valor1, valor2, valor3, maiorAB;

		valor1 = int.Parse(entrada[0]);	
		valor2 = int.Parse(entrada[1]);
		valor3 = int.Parse(entrada[2]);

		maiorAB = (valor1+valor2+Math.Abs(valor1-valor2))/2;

		if (valor3>maiorAB)
			maiorAB = valor3;

		Console.WriteLine("{0} eh o maior", maiorAB);	
	}
}
