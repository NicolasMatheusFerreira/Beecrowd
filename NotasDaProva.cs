using System;

class NotasDaProva {
	static void Main(string[] args) {
		
		int nota;

		nota = int.Parse(Console.ReadLine());

		if (nota==0) {
			Console.WriteLine("E");
		} else if (nota>0 && nota<=35) {
			Console.WriteLine("D");
		} else if (nota>35 && nota<=60) {
			Console.WriteLine("C");
		} else if (nota>60 && nota<=85) {
			Console.WriteLine("B");
		} else if (nota>85 && nota<=100) {
			Console.WriteLine("A");
		} else Console.WriteLine("\aNota invalida!");
	}
}
