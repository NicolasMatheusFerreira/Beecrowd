using System;

class Tabuada {
	static void Main(string[] args) {
		int entrada = int.Parse(Console.ReadLine());

		if (entrada>2 && entrada<1000) {
			for(int j = 1; j<=10; j++) {
				Console.WriteLine("{0} X {1} = {2}", j, entrada, entrada*j);
			}
		}
	}
}
