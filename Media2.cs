using System;

class Media2 {
	static void Main(string[] args) {
		
		double a, b, c, media;

		a = double.Parse(Console.ReadLine());
		b = double.Parse(Console.ReadLine());
		c = double.Parse(Console.ReadLine());

		media = (a*2+b*3+c*5)/(2.0+3.0+5.0);
		Console.WriteLine("MEDIA = {0:0.0}", media);
	}
}
