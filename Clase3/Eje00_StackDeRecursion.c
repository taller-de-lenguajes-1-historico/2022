#include <stdio.h>
int n = 4;
// Función recursiva para calcular el factorial de n
unsigned long long factorial(int n) {
    if (n == 0) { // Caso base
        return 1;
    } else { // Paso recursivo
        return n * factorial(n - 1);
    }
}

int main() {
    int num = 5;
    unsigned long long result = factorial(num);
    printf("El factorial de %d es: %llu\n", num, result);
    return 0;
}
