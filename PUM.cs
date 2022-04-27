using System;

class PUM {
	static void Main(string[] args) {
		int valor = int.Parse(Console.ReadLine());

		int acum = 1, somador = 1;
		while(acum<=valor) {
			for(int k=1; k<=4; k++) {
				if (somador%4!=0) {
					Console.Write("{0} ", somador);
				} else {
					Console.WriteLine("PUM");
				}	
				somador++;			
			}		
			acum++;
		}
	}
}
