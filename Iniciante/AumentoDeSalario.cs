using System;

class AumentoDeSalario {
	static void Main(string[] args) {
		double percent, novo_salario, aumento;
		double salario_funcionario = double.Parse(Console.ReadLine());	

		if (salario_funcionario>=0 && salario_funcionario<=400.00)
			percent = 15.0/100;
		else if (salario_funcionario>=400.01 && salario_funcionario<=800.00)
			percent = 12.0/100;
		else if (salario_funcionario>=800.01 && salario_funcionario<=1200.00)
			percent = 10.0/100;
		else if (salario_funcionario>=1200.01 && salario_funcionario<=2000.00)
			percent = 7.0/100;
		else percent = 4.0/100;

		aumento = percent*salario_funcionario;
		novo_salario = salario_funcionario + aumento;

		Console.WriteLine("Novo salario: {0:0.00}", novo_salario);
		Console.WriteLine("Reajuste ganho: {0:0.00}", aumento);
		Console.WriteLine("Em percentual: {0} %", percent*100);
	}
}
