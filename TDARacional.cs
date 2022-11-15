using System;

class TDARacional {

	static string Simplif(string valor) {
		
		string numerador="", denominador="";
		int j, menor, den, num;
		bool separa = false;

		j = 0;
		while(j<valor.Length) {
			if (valor[j]=='/')
				separa = true;
			else if (!separa)
				numerador+=valor[j];				
			else denominador+=valor[j];
			j++;
		}

		num = int.Parse(numerador);
		den = int.Parse(denominador);

		if (num<den)
			menor = num;
		else menor = den;

		for(int i = 2; i<=menor; i++)
			if (den%i==0 && num%i==0) {
				num /= i;
				den /= i;
			}
		return num+"/"+den;
	}

	static string Divisao(int n1, int d1, int n2, int d2) {

		string num="", den="";

		num+= (n1*d2);
		den+= (n2*d1);
		return num+"/"+den;
	}

	static string Multiplicacao(int n1, int d1, int n2, int d2) {

		string num="", den="";

		num+= (n1*n2);
		den+= (d1*d2);
		return num+"/"+den;
	}

	static string Subtracao(int n1, int d1, int n2, int d2) {

		string num="", den="";

		num+= (n1*d2-n2*d1);
		den+= (d1*d2);
		return num+"/"+den;
	}

	static string Soma(int n1, int d1, int n2, int d2) {
		
		string num="", den="";

		num += (n1*d2+n2*d1);
		den += (d1*d2);
		return num+"/"+den;
	}

	static void Main(string[] args) {
		
		int n = Console.ReadLine();
		

		for(int i = 1; i<=n; i++) {
		
		}
	}
}
