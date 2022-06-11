/*RESERVA DINAMICA DE MEMORIA*/
#include <stdio.h>//contiene las funciones de entrada salida desde la consola
#include <stdlib.h>
#include <string.h>

const int DIM = 15;

//FUNCION PARA LA RESERVA CON MALLOC(), verifica si devuelve NULL
void *ReservarMemoria(int TotBytes);//función que devuelve un puntero a void

int main()
{
  int *p;
  p = (int *)ReservarMemoria(sizeof(int));//direccion de memoria
  *p=5;
  
   //p es una direccióna a donde apunta y *p el contenido de lo apuntado
  printf("Contenido de %d en la direccion: %p\r\n\r\n",*p,p);
  
  free(p);//libera memoria
  
  printf("Libera memoria, %p ahora apunta a %d\r\n\r\n",p,*p);  
  
  getchar();
  return 0;

}

void *ReservarMemoria(int TotBytes)
{
void *pAux;
  
  if((pAux=malloc(TotBytes))==NULL) {
    printf("No pudo reservar memoria dinámica");
    getchar( ); exit(1);
  }
  return(pAux);
}
