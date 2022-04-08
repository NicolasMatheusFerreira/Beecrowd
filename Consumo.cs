using System;

class Consumo {
	static void Main(string[] args) {
		int distancia_percorrida;
		double total_combustivel, combustivel_gasto;

		distancia_percorrida = int.Parse(Console.ReadLine()); //Leitura
		total_combustivel = double.Parse(Console.ReadLine());

		combustivel_gasto = distancia_percorrida/total_combustivel;
		Console.WriteLine("{0:0.000 km/l}", combustivel_gasto);

	}
}
