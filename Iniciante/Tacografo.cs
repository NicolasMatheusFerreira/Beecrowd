using System;

class Tacografo {
	static void Main(string[] args) {
		int n, cont = 1, tempo, veloc, distancia = 0;	

		n = int.Parse(Console.ReadLine());

		while(cont<=n) {
			string[] entrada = Console.ReadLine().Split();
			tempo = int.Parse(entrada[0]);
			veloc = int.Parse(entrada[1]);
			distancia += veloc*tempo;
			
			cont = cont + 1;
		}
		Console.WriteLine(distancia);
	}
}
