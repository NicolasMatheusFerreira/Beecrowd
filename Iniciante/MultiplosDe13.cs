using System;

class MultiplosDe13 {
	static void Main(string[] args) {

		int x, y, soma = 0;

		x = int.Parse(Console.ReadLine());
		y = int.Parse(Console.ReadLine());

		if (x<y)
			for(int a = x; a<=y; a++) {
				if (a%13!=0)
					soma+= a;
			}
		else 
			for(int a = y; a<=x; a++) {
				if (a%13!=0)
					soma+= a;
			}
		Console.WriteLine(soma);
	}
}
