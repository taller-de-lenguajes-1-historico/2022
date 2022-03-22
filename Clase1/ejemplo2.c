#include <stdio.h>
/* Contiene: Operaciones, estándar, de entrada y salida, así como la definición de tipos necesarias para dichas operaciones */
/* https://es.wikipedia.org/wiki/Stdio.h */

int main()
{
    int variable1 = 1;
   
    int * pVariable1;

    pVariable1 = &variable1;

    printf("Contenido: %d \n", variable1);
    // & <- nos permite ver la dirección de memória en la que está la variable
    printf("Dirección: %p \n", &variable1);

    printf("Contenido del puntero pVariable1: %p \n", pVariable1);
    // & <- nos permite ver la dirección de memória en la que está la variable    
    printf("Contenido de lo apuntado por pVariable1: %d \n", *pVariable1);

    getchar();
    return 0;
}