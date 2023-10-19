/*
Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais conforme exemplos.
Fórmula da área: area = π.raio2
Considere o valor de π = 3.14159
Exemplos:
Entrada: Saída:
2.00            A = 12.5664
Entrada: Saída:
100.64          A = 31819.3103
Entrada: Saída:
150.00          A = 70685.7750*/

using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorPi = 3.14159;

            Console.WriteLine("Informe o valor do raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = valorPi * Math.Pow(raio, 2);

            Console.WriteLine($"A = {area:F4}");
        }
    }
}
