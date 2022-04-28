using System;

class SortSimples {
	static void Main(string[] args) {
		int valor1, valor2, valor3;
		
		string[] entrada = Console.ReadLine().Split(); // Entrada

		valor1 = int.Parse(entrada[0]);
		valor2 = int.Parse(entrada[1]);	
		valor3 = int.Parse(entrada[2]);	

		if (valor1>valor2 && valor2>valor3)
			Console.WriteLine("{0}\n{1}\n{2}\n", valor3, valor2, valor1);
		else if (valor2>valor1 && valor1>valor3)
			Console.WriteLine("{0}\n{1}\n{2}\n", valor3, valor1, valor2);
		else if (valor1>valor3 && valor3>valor2)
			Console.WriteLine("{0}\n{1}\n{2}\n", valor2, valor3, valor1);
		else if (valor3>valor1 && valor1>valor2)
			Console.WriteLine("{0}\n{1}\n{2}\n", valor2, valor1, valor3);
		else if (valor2>valor3 && valor3>valor1)
			Console.WriteLine("{0}\n{1}\n{2}\n", valor1, valor3, valor2);
		else if (valor3>valor2 && valor2>valor1)
			Console.WriteLine("{0}\n{1}\n{2}\n", valor1, valor2, valor3);	

		Console.WriteLine("{0}\n{1}\n{2}", valor1, valor2, valor3);
	}
}
