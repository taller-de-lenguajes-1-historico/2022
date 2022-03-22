#include <stdio.h>
/* Contiene: Operaciones, estándar, de entrada y salida, así como la definición de tipos necesarias para dichas operaciones */
/* https://es.wikipedia.org/wiki/Stdio.h */

int main()
{
    int variable1 = 1;
    int variable2 = 2;
    printf("Contenido: %d \n", variable1);
    // & <- nos permite ver la dirección de memória en la que está la variable
    printf("Dirección: %p \n", &variable1);

    printf("Contenido: %d \n", variable2);
    // & <- nos permite ver la dirección de memória en la que está la variable
    printf("Dirección: %p \n", &variable2);

    printf("char          :   %d Bytes\n",   sizeof(char));
    printf("short         :   %d Bytes\n",   sizeof(short));
    printf("int           :   %d Bytes\n",   sizeof(int));
    printf("long          :   %d Bytes\n\n", sizeof(long));

    printf("signed char   :   %d Bytes\n",   sizeof(signed char));
    printf("signed short  :   %d Bytes\n",   sizeof(signed short));
    printf("signed int    :   %d Bytes\n",   sizeof(signed int));
    printf("signed long   :   %d Bytes\n\n", sizeof(signed long));

    printf("unsigned char :   %d Bytes\n",   sizeof(unsigned char));
    printf("unsigned short:   %d Bytes\n",   sizeof(unsigned short));
    printf("unsigned int  :   %d Bytes\n",   sizeof(unsigned int));
    printf("unsigned long :   %d Bytes\n\n", sizeof(unsigned long));

    printf("float         :   %d Bytes\n", sizeof(float));
    printf("double        :   %d Bytes\n", sizeof(double));
    printf("long double   :   %d Bytes\n", sizeof(long double));

    getchar();
    return 0;
}