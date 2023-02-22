#include <stdio.h>
#include <stdlib.h>

#define LIN 5
#define COL 2

float ValoresComprados(float tabela[][COL], int cod, int qtd) {
	
	for(int e = 0; e<LIN; e++)
		if (tabela[e][0]==cod)
			return qtd*tabela[e][1];
	return 0;
}

int main(void) {

	int qtdProdutos, codProduto, qtdUnid;
	float total = 0.0;
	float tabelaPrecos[LIN][COL] = {{1001, 1.50}, {1002, 2.50}, {1003, 3.50}, {1004, 4.50}, {1005, 5.50}};

	scanf("%d", &qtdProdutos);

	for(int i = 1; i<=qtdProdutos; i++) {
		scanf("%d %d", &codProduto, &qtdUnid);
		total = total + ValoresComprados(tabelaPrecos, codProduto, qtdUnid);
	}

	printf("%.2f\n", total);
	return 0;
}
