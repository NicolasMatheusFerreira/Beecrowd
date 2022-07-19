import java.util.Scanner;

public class SobrinhoDoMeio {
	public static void main(String[] args) {
		
		Scanner leitura = new Scanner(System.in);
		int H, Z, L;

		String[] entrada = leitura.nextLine().split(" ");

		H = Integer.parseInt(entrada[0]);
		Z = Integer.parseInt(entrada[1]);
		L = Integer.parseInt(entrada[2]);

		if (H>Z && Z>L)
			System.out.println("zezinho");
		else if (L>Z && Z>H)
			System.out.println("zezinho");
		else if (Z>H && H>L)
			System.out.println("huguinho");
		else if (L>H && H>Z)
			System.out.println("huguinho");
		else if (H>L && L>Z)
			System.out.println("luisinho");
		else if (Z>L && L>H)
			System.out.println("luisinho");		
	}
}
