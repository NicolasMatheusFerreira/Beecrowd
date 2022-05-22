#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>

char *Entrada() {

	char *palavra;

	palavra = malloc(1001*sizeof(char));
	fgets(palavra, sizeof(char)*1001, stdin);
	palavra[strlen(palavra)-1] = '\0';

	return palavra;
}

void Igualar(char text[]) {
	
	if (text[0]!=text[strlen(text)-1] && text[0]==text[strlen(text)-2])
		text[strlen(text)-1] = '\0';
}

int GetPalindromo(char text[]) {

	int qtd = 0;
	for(int i = 0; i<strlen(text); i++)
		qtd++;
	return qtd;
}

void SetString(char text[]) {

	for(int i = 0; i<strlen(text); i++)
		text[i] = ' ';
}

void Concatena(char *text, char caracter) {
	
	text[strlen(text)] = caracter;
	text[strlen(text)+1] = '\0';
}

void *Inverte(char palavra[]) {
	
	char *resultado="";

	resultado = malloc(1001*sizeof(char));

	for(int i = strlen(palavra) - 1; i>=0; i--) {
		Concatena(resultado, palavra[i]);
	}	
	
	return resultado;
}


bool Palindromo(char palavra[]) {

	if (strcmp(palavra, Inverte(palavra))==0)
		return true;
	return false;
}

int MaiorPalindromo(char palavra[]) {

	char aux[1001]="";
	int maior = 0;

	for (int i = 0; i<strlen(palavra); i++) {
		SetString(aux);
		for(int y = i; y<strlen(palavra); y++) {
			Concatena(aux, palavra[y]);
			if (strlen(aux)>=2)		
				if (Palindromo(aux)) {
					if (GetPalindromo(aux)>maior)
						maior = GetPalindromo(aux);									
				}
		}	
	}
	return maior;
}

int main(void) {	

	char *nome = Entrada();

	if (strlen(nome)%2==1) {
		Igualar(nome);
		if (nome[2]!=nome[3])
			for(int i = 2; i<strlen(nome)-1; i++)
				nome[i] = nome[i+1];
	
		nome[strlen(nome)-1]='\0';
	
	}
	
	printf("O maior palindromo possivel eh: %d\n", MaiorPalindromo(nome));
	return 0;
}
