using System;

class CrescenteEDecrescente {
	static void Main(string[] args) {

		int x = 0, y = 0;
		do {
			string[] entrada = Console.ReadLine().Split();
			x = int.Parse(entrada[0]);
			y = int.Parse(entrada[1]);

			if (x>y)
				Console.WriteLine("Decrescente");
			else if (x<y)
				Console.WriteLine("Crescente");
		} while(x!=y);
	}
}
