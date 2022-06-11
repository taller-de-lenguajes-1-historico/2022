/*RESERVA DINAMICA DE MEMORIA*/
#include <stdio.h>//contiene las funciones de entrada salida desde la consola
#include <stdlib.h>
#include <string.h>

const int DIM = 15;

typedef struct Tnodo
{
   int dato;
   Tnodo * siguiente;
}Tnodo;

void  *ReservarMemoria(int TotBytes);
Tnodo *CrearListaVacia();
void CrearNodo(Tnodo ** Start,int dato);
void CrearNodoALFinal(Tnodo ** Start,int dato);
int BuscarNodo(Tnodo ** Start,int dato);
void ELiminarNodo(Tnodo ** Start,int dato);

int main()
{

  //Cabecera de la Lista
  Tnodo * Start = CrearListaVacia();
  // nuevo nodo
  CrearNodo(&Start, rand() % 99); 
  CrearNodo(&Start, 5); 
  // Insertar nodo a la lista
  CrearNodoALFinal(&Start, 10);
  CrearNodoALFinal(&Start, 20);
  CrearNodoALFinal(&Start, 30);
  BuscarNodo(&Start,10);
  
  Tnodo * Aux = Start;
  while (Aux)
  {
    printf("%d \n", Aux->dato);
    Aux = Aux->siguiente;
  }
  

  getchar();
  return 0;

}

void ELiminarNodo(Tnodo ** Start,int dato)
{
  int DatoBuscado = dato;
  Tnodo * Aux = *Start;
  Tnodo * AuxAnterior;
  
  while (Aux && Aux->dato != DatoBuscado)
  {
    AuxAnterior = Aux;
    Aux = Aux->siguiente;
  }

  if(Aux)
  {
    AuxAnterior->siguiente = Aux ->siguiente;
    printf("Dato Encontado: %d", Aux->dato);
    free(Aux);
    printf("Dato Eliminado: %d", Aux->dato);
  }

}

int BuscarNodo(Tnodo ** Start,int dato)
{
  
  Tnodo * Aux = *Start;

  while (Aux && Aux->dato != dato)
  {
    Aux = Aux->siguiente;
  }
}


Tnodo * CrearListaVacia()
{
    return NULL;
}

void CrearNodo(Tnodo ** Start,int dato)
{
  Tnodo * nodo = (Tnodo *) malloc(sizeof(Tnodo));
  nodo->dato = dato;
  nodo->siguiente = NULL;
  *Start = nodo;
}


void CrearNodoALFinal(Tnodo ** Start,int dato)
{
  Tnodo * Aux = *Start;
  Tnodo * nodo = (Tnodo *) malloc(sizeof(Tnodo));
  nodo->dato = dato;
  nodo->siguiente = NULL;

  while (Aux->siguiente)
  {
    Aux = Aux->siguiente;
  }
   Aux->siguiente = nodo;
  
}


// Reserva memoria 
///devuelve null si no se pudo reservar y cierra el programa
///devuelve un puntero a la reserva si tuvo exito
void *ReservarMemoria(int TotBytes)
{
void *pAux;
  
  if((pAux=malloc(TotBytes))==NULL) {
    printf("No pudo reservar memoria dinámica");
    getchar( ); exit(1);
  }
  return(pAux);
}
