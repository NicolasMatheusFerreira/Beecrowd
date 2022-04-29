using System;

class ConversaoDeTempo {
	static void Main(string[] args) {
		
		int entrada = int.Parse(Console.ReadLine());
		int horas = 0, minutos = 0, segundos = 0;

		while(entrada>0) {
			if (entrada>=3600) {
				entrada = entrada - 3600;
				horas++;
			} else if (entrada>=60) {
				entrada = entrada - 60;
				minutos++;
			} else {
				entrada -= 1;
				segundos++;
			}
		}

		Console.WriteLine("{0}:{1}:{2}", horas, minutos, segundos);
	}
}
