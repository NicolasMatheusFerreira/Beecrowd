using System;

class GastoDeCombustivel {
	static void Main(string[] args) {

		int qtdTempo;
		double km_rodados, veloc_media;

		qtdTempo = int.Parse(Console.ReadLine());
		km_rodados = double.Parse(Console.ReadLine());

		veloc_media = km_rodados*qtdTempo/12.0;
		Console.WriteLine("{0:0.000}", veloc_media);
	}
}
