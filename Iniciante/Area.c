#include <stdio.h>
#include <math.h>

#define PI 3.14159

float areaRetangulo(float a, float b) {
	return a*b;
}

float areaQuadrado(float b) {
	return b*b;
}

float areaTrapezio(float a, float b, float c) {
	return (a+b)*c/2;
}

float areaCirculo(float c) {
	return PI*pow(c, 2);
}

float areaTriangulo(float a, float c) {
	return a*c/2;
}

int main(void) {

	float a, b, c;

	scanf("%f %f %f", &a, &b, &c);

	printf("TRIANGULO: %.3f\n", areaTriangulo(a, c));
	printf("CIRCULO: %.3f\n", areaCirculo(c));
	printf("TRAPEZIO: %.3f\n", areaTrapezio(a, b, c));
	printf("QUADRADO: %.3f\n", areaQuadrado(b));
	printf("RETANGULO: %.3f\n", areaRetangulo(a, b));

	return 0;
}
