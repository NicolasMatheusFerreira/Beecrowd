using System;

class TesteDeSelecao1 {
	static void Main(string[] args) {
		
		string[] entrada = Console.ReadLine().Split();

		int a, b, c, d;

		a = int.Parse(entrada[0]);
		b = int.Parse(entrada[1]);
		c = int.Parse(entrada[2]);
		d = int.Parse(entrada[3]);

		if (b>c && d>a && (c+d)>(a+b) && c>0 && d>0 && a%2==0) {
			Console.WriteLine("Valores aceitos");
		} else Console.WriteLine("Valores nao aceitos");
	}
}
