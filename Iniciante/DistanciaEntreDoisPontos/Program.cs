﻿using System;

namespace DistanciaEntreDoisPontos
{
    class Program
    {
	static double Distancia(double x1, double y1, double x2, double y2) {

		return Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
	}

	static void Main(string[] args) {

		string[] entrada1 = Console.ReadLine().Split(' ');
		string[] entrada2 = Console.ReadLine().Split(' ');

		Console.WriteLine("{0:0.0000}", Distancia(Convert.ToDouble(entrada1[0]), Convert.ToDouble(entrada1[1]), Convert.ToDouble(entrada2[0]), Convert.ToDouble(entrada2[1])));
	}
    }
}
