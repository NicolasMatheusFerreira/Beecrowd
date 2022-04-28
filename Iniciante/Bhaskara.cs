using System;

class Bhaskara {
	static void Main(string[] args) {
		double a, b, c, delta, r1=0, r2=0;
		string[] entrada = Console.ReadLine().Split();

		a = double.Parse(entrada[0]); // Entrada
		b = double.Parse(entrada[1]);
		c = double.Parse(entrada[2]);

		delta = Math.Pow(b, 2)-4*a*c; // Processamento
	
		if (delta>0 && a>0) {

			r1 = (-b+Math.Sqrt(delta))/(2*a);
			r2 = (-b-Math.Sqrt(delta))/(2*a);			

			Console.WriteLine("R1 = {0:0.00000}", r1); // Saída
			Console.WriteLine("R2 = {0:0.00000}", r2);


		} else Console.WriteLine("Impossivel calcular");


	}
}
