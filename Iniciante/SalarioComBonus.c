#include <stdio.h>
#include <stdlib.h>

int main(void) {

	char nome[101];
	float salarioFixo, vendasMes, total;
	     
	setbuf(stdin, NULL);
	scanf("%s", &nome);

	scanf("%f", &salarioFixo);

	scanf("%f", &vendasMes);

	total = salarioFixo + 15/100*vendasMes + vendasMes;
	printf("TOTAL = R$ %.2f", total);
	return 0;
}
