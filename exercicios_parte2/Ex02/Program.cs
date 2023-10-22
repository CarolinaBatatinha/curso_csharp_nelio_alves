/*
Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
Exemplos:
Entrada:            Saída:
12                  PAR

Entrada:            Saída:
-27                 IMPAR

Entrada:            Saída:
0                   PAR
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número inteiro qualquer: ");
        int num = int.Parse(Console.ReadLine());

        if (num %2  == 0)
        {
            Console.WriteLine("PAR");
        }
        else
        {
            Console.WriteLine("ÍMPAR");
        }
    }
}