#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void Repete(char texto[], int qtd) {

	int i, j;
	for(i = 0; i<strlen(texto); i++) {
		printf("%c", texto[i]);
		if (i==9 && texto[i]=='a') {
			for(j = 1; j<qtd; j++)
				printf("%c", texto[i]);
		}
	}
	printf("\n");
}

int main(void) {

	char text[1001];
	strcpy(text, "Feliz natal!");
	int c;
	scanf("%d", &c);
	if (c>=1 && c<=10000)
		Repete(text, c);
}
