// --------------------------------------------------------------------------
//   Programa para somar incrementar um número com o anterior INDICE vezes
// --------------------------------------------------------------------------

#include <stdlib.h>
#include <stdio.h>

int Soma() {
    int SOMA = 0, INDICE = 13, K = 0;

    while(K < INDICE){
        K = K + 1;
        SOMA = SOMA + K;
    };
    return SOMA;
}

int main(void) {
    int valorSoma = Soma();
    printf("Soma = %d \n", valorSoma);

    return 0;
}
