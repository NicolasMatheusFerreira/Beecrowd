using System;

class SomaDeImparesConsecutivosI {
	static void Main(string[] args) {
		
		int x,y, somaPositivos = 0, somaNegativos = 0;

		x = int.Parse(Console.ReadLine());
		y = int.Parse(Console.ReadLine());

		if (x>y) {
			for(int a = y + 1; a<x; a++) {			
				if (a%2!=0) {			
					if (a>0) {
						somaPositivos+=a;
					} else {
						somaNegativos-=a;
					}
				}
			}
			Console.WriteLine(somaPositivos-somaNegativos);

		}
	}
}
