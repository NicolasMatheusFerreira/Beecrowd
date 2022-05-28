#include <stdio.h>
#include <stdlib.h>

int SomaImparesConsecutivos(int num, int qtd) {

	int z = 1, positivo = 0, negativo = 0;
	while(z<=qtd) {
		if (num%2==1 && num>0) {
			positivo = positivo + num;		
			z++;	
		} else if (num%2==-1 && num<0) {
			negativo = negativo - num;			
			z++;	
		} 
		num++;
	}	
	return positivo-negativo;
}

int main(int argc, char *argv[]) {

	int CasosTeste, vlr, qtd;	
	scanf("%d", &CasosTeste);

	for(int q = 1; q<=CasosTeste; q++) {
		scanf("%d %d", &vlr, &qtd);
		printf("%d\n", SomaImparesConsecutivos(vlr, qtd));
	}
	return 0;
}
