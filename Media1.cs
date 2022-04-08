using System;

class Media1 {
	static void Main(string[] args) {
		double A, B, media=0;

		A = double.Parse(Console.ReadLine());
		B = double.Parse(Console.ReadLine());
		
		media = ((3.5*A)+(7.5*B))/11;
		Console.WriteLine("MEDIA =  {0:0.00000}", media);
	}
}
