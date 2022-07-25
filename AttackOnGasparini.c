#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int CalculaTamanhoMuralha(int n, int x, char tam[], int p, int m, int g) {

	int qtdP = 0, qtdM = 0, qtdG = 0, total, flag, qtdMuralhas = 1; 

	for(int i = 0; i<strlen(tam); i++) {		
		if (tam[i]=='P')
			qtdP++;
		else if (tam[i]=='M')
			qtdM++;
		else if (tam[i]=='G')
			qtdG++;
	}
	
	total = qtdP*p+qtdM*m+qtdG*g;
	
	flag = x;

	while(flag<total) {				
		flag += x;
		qtdMuralhas++;
	}
	
	return qtdMuralhas;
}

int main(void) {
	
	int n, x;
	int p, m, g;

	scanf("%d %d", &n, &x);

	char tam[n];
	if (n>=1 && n<=3000000 && x>=1 && x<=1000000) {
		scanf("%s", &tam);
		scanf("%d %d %d", &p, &m, &g);

		if (p>=1 && p<=x && m>=1 && m<=x && g>=1 && g<=x) {
			int total = CalculaTamanhoMuralha(n, x, tam, p, m, g);
			printf("%d\n", total);
		}
	} 
	return 0;
}
