using System;

class AreaDoCirculo {
	static void Main(string[] args) {
		double raio, area = 0;

		raio = double.Parse(Console.ReadLine());

		area = 3.14159*raio*raio;

		Console.WriteLine("A={0:0.0000}", area);
	}
}
