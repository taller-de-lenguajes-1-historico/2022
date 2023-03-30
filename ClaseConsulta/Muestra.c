/*Ejemplo de aritmetica de punteros. ARREGLO y PUNTERO*/
#include <stdio.h>
#include <stdlib.h>

int main()
{
  // ----------- ESTÁTICO ------------ //
  int Arreglo[] = {1,2,3}; // internamente es un puntero pero se presenta como un arreglo
  int filas = 3;
  int columnas = 3;

  printf("\r\nutilizando notación de arreglos\r\n");
  for (int i = 0; i < 3; i++)
  {
    printf("%4d", Arreglo[i]); 
  }

  printf("\r\nutilizando notación de punteros\r\n");
  for (int i = 0; i < 3; i++)
  {
    printf("%4d", *(Arreglo + i));
  }

  // --------- DINAMICA ------------ //
  int tamanioArreglo = 10;

  int * arregloDim = (int *) malloc(sizeof(int) * tamanioArreglo);

  for (int i = 0; i < tamanioArreglo; i++)
  {
    arregloDim[i] = i + 1;
  }

  printf("\r\nutilizando notación de arreglos y memoria dinámica\r\n");
  for (int i = 0; i < 3; i++)
  {
    printf("%4d", arregloDim[i]);
  }

  
  // --------- MATRICES ------------ //
  printf("\r\nMatrices\r\n");
  int  matrizEstatica[3][3];

  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      matrizEstatica[i][j] = i+j;
    }
  }

  printf("\r\n mostrando elementos de la matriz estática\r\n");
  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      printf("%4d", matrizEstatica[i][j]);
    }
     printf("\r\n");
  }


  // --------- MATRICES DINÁMICAS ------------ //
  printf("\r\nMatrices Dinamicas\r\n");
  int ** matrizDinamica = (int **) malloc(sizeof(int *) * filas);

  for (int i = 0; i < 3; i++)
  {
    matrizDinamica[i] = (int *) malloc(sizeof(int) * columnas);

    for (int j = 0; j < 3; j++)
    {
      matrizDinamica[i][j] = i+j;
      printf("%p   ", &matrizDinamica[i][j]);
    }
     printf("\r\n");
  }

  for (int i = 0; i < 3; i++)
  {
    free(matrizDinamica[i]);
  }
  free(matrizDinamica);

  printf("\r\nMatrices Dinamicas v2\r\n");

  int * matrizDinamicaV2 = (int *) malloc(sizeof(int) * columnas * filas);

  for (int i = 0; i < 3; i++)
  {
    for (int j = 0; j < 3; j++)
    {
      *((matrizDinamicaV2 + i  * columnas) + j) = i+j;
      printf("%4d", *((matrizDinamicaV2 + i  * columnas) + j));
    }
     printf("\r\n");
  }

}      


 

