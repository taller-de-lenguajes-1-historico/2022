/*RESERVA DINAMICA DE MEMORIA*/
#include <stdio.h>//contiene las funciones de entrada salida desde la consola
#include <stdlib.h>
#include <string.h>

const int DIM = 15;

const int Filas = 3;
const int Columnas = 2;

//FUNCION PARA LA RESERVA CON MALLOC(), verifica si devuelve NULL
void *ReservarMemoria(int TotBytes);//función que devuelve un puntero a void

int main()
{
    int *pVect;
    int  i;

    pVect = (int *)ReservarMemoria(DIM*sizeof(int)); //Reservo DIM elementos  
    for(i=0;i<DIM;i++)
    {
        *(pVect+i) = 100+ rand()  % 801;//entre 100 y 900
        printf("pVect[%d]: %d \r\n",i,*(pVect+i));
    }  

     free(pVect);

    //Creadon una matriz dinámicamente con punteros dobles y notación subIndexada 
    int ** pMatriz1 = (int **)ReservarMemoria(Columnas * sizeof(int *)); //Reservo las columnas (cada columna es un puntero)

    for (int i = 0; i < Columnas; i++)
    {
        pMatriz1[i] = (int *)ReservarMemoria(Filas * sizeof(int)); //Reservo las Filas (cada fila es un puntero)
        for (int j = 0; j < Filas; j++)
        {
            pMatriz1[i][j] = j;
        }          
    }
    
    //Creadon una matriz dinámicamente con arismética de punteros 
    int *pMatriz2 = (int *)malloc(Filas * Columnas * sizeof(int)); //Reservo las Filas y columnas en un solo bloque 
    for (int i = 0; i < Columnas; i++)
    {        
        for (int j = 0; j < Filas; j++)
        {
            * (pMatriz2 + i * Columnas + j) = j; // debo utilizar notación indexada
        }          
    }
    
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



