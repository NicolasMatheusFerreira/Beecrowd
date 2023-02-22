#include <stdio.h>
#include <stdlib.h>

int main(void) {

	int num, w = 1;

	scanf("%d", &num);

	for(int w = num; w<num+12; w++)
		if (w%2==1)
			printf("%d\n", w);		
	
	return 0;
}
