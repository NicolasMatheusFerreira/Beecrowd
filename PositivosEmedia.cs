using System;

class PositivosEmedia {
	static void Main(string[] args) {
			
		double valores = 0, media, vlrPositivos = 0, soma = 0;
		for(int i=1; i<=6.0; i++) {
			valores =  double.Parse(Console.ReadLine());

			if (valores>0) {
				vlrPositivos++;
				soma += valores;
			}
			
		}
		media = soma/vlrPositivos;
		Console.WriteLine("{0} valores positivos", vlrPositivos);
		Console.WriteLine("{0:0.0}", media);
	}
}
