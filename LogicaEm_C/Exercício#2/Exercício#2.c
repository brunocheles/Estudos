// --------------------------------------------------------------------------
//  Programa para verificar se o número faz parte da sequência de Fibonacci
// --------------------------------------------------------------------------

#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int SequenciaFibonacci (int num) {
    int j = 1, i;
    for(i = 0;(i <= num || j <= num);) {
        if (num == j || num == i) {
            return 1;
        }
        i = i + j;
        j = j + i;
    }
    return 0;
}

int main(void) {
    int numero;
    printf("Digite um numero:");
    scanf("%d",&numero);

    if(SequenciaFibonacci(numero)) {
        printf("\n Este numero pertence a sequencia de Fibonacci.");
    }else {
        printf("\n Este numero nao pertence a sequencia de Fibonacci.");
    }
}
