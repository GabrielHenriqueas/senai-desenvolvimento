//  Pesquise como funciona o algoritmo Fibonacci.
//  Faça um programa que gere a série até que o valor seja maior que 500.

int a = 1;
int b = 2;
int c = a += b;

a += b = c;

Console.WriteLine($"{c}");


// for(int cont = 1 ; cont <= 10 ; cont++)
// {
//     a += b = c;

//     Console.WriteLine($"{c}");
    
//     c += b = a;
//     c = b;
    
// }