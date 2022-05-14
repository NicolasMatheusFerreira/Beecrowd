using System;

class TiposDeTriangulos {

	static void Ordena(ref double a, ref double b, ref double c) {
		
		double aux = 0;
		for(int i=1; i<3; i++) {
			if (a<b) {
				aux = a;
				a = b;
				b = aux;
			}

			if (b<c) {
				aux = b;
				b = c;
				c = aux;
			}
		}
	}

	static void Main(string[] args) {
		
		double a, b, c, aux = 0;

		string[] entrada = Console.ReadLine().Split();

		a = double.Parse(entrada[0]);
		b = double.Parse(entrada[1]);
		c = double.Parse(entrada[2]);

		Ordena(ref a, ref b, ref c);

		if (a>=b+c)
			Console.WriteLine("NAO FORMA TRIANGULO");
		else if (Math.Pow(a,2)==Math.Pow(b,2)+Math.Pow(c,2))
			Console.WriteLine("TRIANGULO RETANGULO");
		else if (Math.Pow(a,2)>Math.Pow(b,2)+Math.Pow(c,2))
			Console.WriteLine("TRIANGULO OBTUSANGULO");
		else if (Math.Pow(a,2)<Math.Pow(b,2)+Math.Pow(c,2))
			Console.WriteLine("TRIANGULO ACUTANGULO");

		if (a==b && b==c)
			Console.WriteLine("TRIANGULO EQUILATERO");
		else if (a==b || a==c || b==c)
			Console.WriteLine("TRIANGULO ISOSCELES");
	}
}
