import java.util.Scanner;

public class Palavrao {

	public static void main(String[] args) {
		Scanner leitura = new Scanner(System.in);

		String entrada;

		entrada = leitura.nextLine();

		if (entrada.length()<20) {
			if (entrada.length()<10) {
				System.out.println("palavrinha");
			} else System.out.println("palavrao");
		}
	}
}
