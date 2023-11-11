// --------------------------------------------------------------------------
//                  Programa para inverter a frase digitada
// --------------------------------------------------------------------------
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <locale.h>

int main(void) {
    setlocale(LC_ALL, "Portuguese");
    char frase[150];
    int tamanhoFrase = 0, i = 0;

    printf("Digite uma frase(Máximo 150 caracteres): ");
    gets(frase);


    tamanhoFrase = strlen(frase);

    printf("\n Frase Invertida: ");
    for (i = tamanhoFrase; i >= 0; i--) {
        printf("%c",frase[i]);
    }

    printf("\n Frase original: %s \n",frase);
    getch();
}
