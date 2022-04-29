using System;

class IdadeEmDias {
	static void Main(string[] args) {
		
		int anos = 0, meses = 0, dias = 0;
		int n = int.Parse(Console.ReadLine());

		while(n>0) {
			if (n>=365) {
				n-= 365;
				anos++;
			} else if (n>=30) {
				n-= 30;
				meses++;
			} else {
				n-= 1;
				dias++;
			}
		}

		Console.WriteLine("{0} ano(s)\n{1} mes(es)\n{2} dia(s)", anos, meses, dias);
	}
}
