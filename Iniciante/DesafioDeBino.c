#include <stdio.h>
#include <stdlib.h>

#define TAM 4

void Multiplos(int valores[], int tam, int mult[]) {
	
	int s = 0, v = 0, cont; 

	cont = 0;
	while(s<TAM) {
		cont = 0;
		v = 0;
		while(v<tam) {
			if (valores[v]%mult[s]==0)
				cont++;
			v++;
		}
		printf("%d Multiplo (s) de %d\n", cont, mult[s]);
		s = s + 1;
	}
}

int main(void) {

	int qtd;
	int mult[] = {2, 3, 4, 5};
	
	scanf("%d", &qtd);

	int vlrs[qtd];

	for(int q = 0; q<qtd; q++)
		scanf("%d", &vlrs[q]);

	Multiplos(vlrs, qtd, mult);
	return 0;
}
