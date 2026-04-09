#include<stdio.h>
#include<stdlib.h>
#include <time.h>

int main() {
	srand(time(NULL));
	char pole[5];
	
	for (int i = 0; i < 5; i++) {
		printf(" zadej znak nebo číslo: ");
		scanf(" %c", &pole[i]);
	}
	for (int i = 0; i < 5; i++) {
		printf("pole je velke: %c\n ", pole[i]);

	}
	return 0;
}