using System;

class NotasEmoedas {

	static void Notas(double entrada) {

		int cem =0, cinquenta = 0, vinte = 0, dez = 0, cinco = 0, dois =0;
		double UmReal = 0, ZeroCinquenta = 0, ZeroVinteCinco = 0, ZeroDez = 0, ZeroCinco = 0, ZeroUm = 0;

		while(entrada>0) {
			if (entrada>=100) {
				entrada = entrada - 100;
				cem++;
			} else if (entrada>=50) {
				entrada = entrada - 50;
				cinquenta++;
			} else if (entrada>=20) {
				entrada = entrada - 20;
				vinte++;
			} else if (entrada>=10) {
				entrada = entrada - 10;
				dez++;
			} else if (entrada>=5) {
				entrada = entrada - 5;
				cinco++;
			} else if (entrada>=2) {
				entrada = entrada - 2;
				dois++;
			} else if (entrada>=1) {
				entrada = entrada - 1;
				UmReal++;
			} else if (entrada>=0.50) {
				entrada = entrada - 0.50;
				ZeroCinquenta++;
			} else if (entrada>=0.25) {
				entrada = entrada - 0.25;
				ZeroVinteCinco++;
			} else if (entrada>=0.10) {
				entrada = entrada - 0.10;
				ZeroDez++;
			} else if (entrada>=0.05) {
				entrada = entrada - 0.05;
				ZeroCinco++;
			} else if (entrada>=0.01) {
				entrada = entrada - 0.01;
				ZeroUm++;
			} 

//			Console.WriteLine(entrada);
		}

		Console.WriteLine("NOTAS:");
		Console.WriteLine("{0} notas(s) de R$ 100.00\n{1} notas(s) de R$ 50.00\n{2} notas(s) de R$ 20.00", cem, cinquenta, vinte);
		Console.WriteLine("{0} notas(s) de R$ 10.00\n{1} notas(s) de R$ 5.00\n{2} nota(s) de R$ 2.00", dez, cinco, dois);
		Console.WriteLine("{0} moeda(s) de R$ 1.00", UmReal);
	}

	static void Main(string[] args) {
		
		double entrada = double.Parse(Console.ReadLine());				
	
		Notas(entrada);	
	}
}
