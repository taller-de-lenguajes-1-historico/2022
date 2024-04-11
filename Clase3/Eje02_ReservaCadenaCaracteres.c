#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char * Origen = "Hola mundo";
    int tamanioSinNulo = strlen("Hola mundo"); // no considera el caracter nulo por lo tanto devuelve 10
    int tamanioconCaracterNulo = sizeof("Hola mundo"); // considera el caracter nulo por lo tanto devuelve 11
    
    char * Cadena;     
    Cadena = (char *) malloc (sizeof(char) * tamanio + 1); // Reserva de memoria para la cadena pero aumento 1 byte para el carcter nulo
    
    strcpy(Cadena, "Hola mundo");  
    printf("%s",Cadena);
    
    getchar();  
    return 0;
}