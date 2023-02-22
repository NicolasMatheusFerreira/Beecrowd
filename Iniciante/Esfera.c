#include <stdio.h>
#include <stdlib.h>
#include <math.h>

#define PI 3.14159

float Potencia(float base, int expoente) {

	float result = 1, a;
	for(a = 1; a<=expoente; a++) {
		result = result * base;	
	}
	return result;	
}

int main(void) {

	float volume, raio;

	scanf("%f", &raio);


	volume = 4/3.0*PI*pow(raio, 3);

	printf("VOLUME = %.3f\n", volume);

	return 0;
}
