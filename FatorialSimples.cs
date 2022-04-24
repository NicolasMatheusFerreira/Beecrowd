using System;

class FatorialSimples {
	static void Main(string[] args) {

		int cont, fat = 1;
		int entrada = int.Parse(Console.ReadLine());
		
		cont = entrada;

		while(cont>1.0) {
			fat = fat * cont;
			cont--;
		}
		Console.WriteLine(fat);
	}
}
