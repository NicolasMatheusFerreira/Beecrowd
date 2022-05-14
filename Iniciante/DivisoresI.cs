using System;

class DivisoresI {
	static void Main(string[] args) {

		int num = int.Parse(Console.ReadLine());

		for(int i=1; i<=num; i++) {
			if (num%i==0)
				Console.WriteLine(i);
		}
	}
}
