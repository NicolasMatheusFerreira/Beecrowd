using System;

namespace Cedulas
{
    class Program
    {
	static void decompoeCedulas(double[] ced, int[] qtd, double valor) {
		
		int j = ced.Length - 1;
		while(j>=0) {
			qtd[j] = Convert.ToInt32(Math.Floor(valor/ced[j]));		
			valor = valor%ced[j];	
			j--;
		}
	}

        static void Main(string[] args)
        {
            double[] cedulas = new double[] {1.0, 2.0, 5.0, 10.0, 20.0, 50.0, 100.0};

	    int[] qtdCedulas = new int[cedulas.Length];
	    
	    int entrada = Convert.ToInt32(Console.ReadLine());

	    if (entrada<=1000000) {
	    	decompoeCedulas(cedulas, qtdCedulas, entrada);

		    Console.WriteLine("{0}", entrada);
		    for(int a = cedulas.Length-1; a>=0; a = a - 1)
			Console.WriteLine("{0} nota(s) de R$ {1:0.00}", qtdCedulas[a], cedulas[a]);
		    Console.WriteLine();
	    }

        }
    }
}
