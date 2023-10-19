/*
 * Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
Exemplos:
Entrada:         Saída:
 5               DIFERENCA = -26
 6
 7
 8

Entrada:        Saída:
 5              DIFERENCA = 86
 6
-7
 8
 */
using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor inteiro para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor inteiro para B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor inteiro para C: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor inteiro para D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }
}
