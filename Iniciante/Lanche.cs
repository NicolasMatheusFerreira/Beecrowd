using System;

class Lanche {
	static void Main(string[] args) {
		int codigo, qtd;
		double total = 0;

		string[] entrada = Console.ReadLine().Split();
		
		codigo = int.Parse(entrada[0]);
		qtd = int.Parse(entrada[1]);

		if (codigo==1)
			total = 4.00*qtd;
		else if (codigo==2)
			total = 4.50*qtd;
		else if (codigo==3)
			total = 5.00*qtd;
		else if (codigo==4)
			total = 2.00*qtd;
		else if (codigo==5)
			total = 1.50*qtd;

		Console.WriteLine("Total: R$ {0:0.00}", total);
	}
}
