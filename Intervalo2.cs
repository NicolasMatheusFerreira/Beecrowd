using System;

class Intervalo2 {
	static void Main(string[] args) {
		
		int num, dentroIntervalo = 0, foraIntervalo = 0;
		int qtdRepeticoes = int.Parse(Console.ReadLine());

		for(int run=1; run<=qtdRepeticoes; run++) {
			num = int.Parse(Console.ReadLine());

			if (num>=10 && num<=20) {
				dentroIntervalo++;
			} else
				foraIntervalo++;
		}
		Console.WriteLine("{0} in", dentroIntervalo);
		Console.WriteLine("{0} out", foraIntervalo);
	}
}
