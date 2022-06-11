#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char * Cadena;
    Cadena = (char *) malloc (sizeof(char) * 10);
    strcpy(Cadena, "Hola mundo");  
    printf("%s",Cadena);
    getchar();  
    return 0;
}