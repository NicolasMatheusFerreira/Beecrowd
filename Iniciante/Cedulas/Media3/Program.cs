using System;

namespace Media3
{
    class Program
    {
	static double calculaMedia(double[] pesos, double[] notas) {
		
		double media = 0, somaPesos = 0;
		
		for(int q = 0; q<notas.Length; q++) {
			media = media + notas[q]*pesos[q];
			somaPesos = somaPesos + pesos[q];
		}
		return media/somaPesos;
	}

        static void Main(string[] args)
        {
	    double[] pesos = new double[] {2.0, 3.0, 4.0, 1.0};	 
            string[] entrada = Console.ReadLine().Split(' ');
	    double[] notas = new double[entrada.Length];
	   
	    for(int z = 0; z<entrada.Length; z++)
		notas[z] = Convert.ToDouble(entrada[z]);

	    double notaFinal = calculaMedia(pesos, notas);

	    if (notaFinal>7.0) {
		Console.WriteLine("Media: {0:0.0}", notaFinal);
	    	Console.WriteLine("Aluno aprovado.");
	    } else if (notaFinal<5.0) {
	       	Console.WriteLine("Media: {0:0.0}", notaFinal);
	    	Console.WriteLine("Aluno reprovado.");
	    } else {	    	
		double notaExame = double.Parse(Console.ReadLine());

       	        Console.WriteLine("Media: {0:0.0}", notaFinal);
		Console.WriteLine("Aluno em exame.");
		Console.WriteLine("Nota do exame: {0:0.0}", notaExame);

		notaFinal = (notaExame+notaFinal)/2.0;

		if (notaFinal>=5.0) {
			Console.WriteLine("Aluno aprovado");	
		} else {
			Console.WriteLine("Aluno reprovado");
		}
		Console.WriteLine("Media final: {0:0.0}", Math.Floor(notaFinal));
		Console.WriteLine();
	    }
        }
    }
}
