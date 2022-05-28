#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void Leitura(int *valorA, int *valorB) {

	int x, y;
	scanf("%d %d", &x, &y);

	*valorA = x;
	*valorB = y;
}
char *Quadrante(int x, int y) {
	
	if (x>0 && y>0) {
		return "primeiro";
	} else if (x<0 && y>0) {
		return "segundo";
	} else if (x<0 && y<0) {
		return "terceiro";
	} else if (x>0 && y<0) {
		return "quarto";
	} else return "	";
}

int main(int argc, char *argv[]) {

	int a,b, i = 0;
	char saida[1001][11];
	do {
		Leitura(&a,&b);
		strcpy(saida[i++], Quadrante(a,b));
	} while(a!=0 && b!=0);

	for(int l = 0; l<i; l++)
		printf("%s\n", saida[l]);
	return 0;
}
