#include <stdio.h>
/* Contiene: Operaciones, estándar, de entrada y salida, así como la definición de tipos necesarias para dichas operaciones */
/* https://es.wikipedia.org/wiki/Stdio.h */

void CambiarValorVariable(int B);

void CambiarValorVariablePorReferencia(int * B);

int main()
{
    int A = 10;
    
    CambiarValorVariable(A);

    printf("Contenido Fuera de la función: %d \n", A);

    CambiarValorVariablePorReferencia(A);

    printf("Contenido Fuera de la función: %d \n", A);
 
    
    getchar();
    return 0;
}

void CambiarValorVariable(int B)
{
    B = B + 10;
    printf("Contenido dentro de la función: %d \n", B);
}


void CambiarValorVariablePorReferencia(int * B)
{
    *B = *B + 10;
    printf("Contenido dentro de la función: %d \n", B);
}