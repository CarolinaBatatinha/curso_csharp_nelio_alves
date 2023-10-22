/*
Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
Exemplos:
Entrada:        Saída:
-10             NEGATIVO

Entrada:        Saída:
8               NAO NEGATIVO

Entrada:        Saída:
0               NAO NEGATIVO

*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número inteiro (positivo ou negativo): ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 0) 
        {
            Console.WriteLine("NÃO NEGATIVO");
        }
        else
        {
            Console.WriteLine("NEGATIVO");
        }
    }
}