/*
Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
Exemplos:
Entrada:                        Saída:
3.0 4.0 5.2                     TRIANGULO: 7.800
                                CIRCULO: 84.949
                                TRAPEZIO: 18.200
                                QUADRADO: 16.000
                                RETANGULO: 12.000

Entrada:                        Saída:
12.7 10.4 15.2                  TRIANGULO: 96.520
                                CIRCULO: 725.833
                                TRAPEZIO: 175.560
                                QUADRADO: 108.160
                                RETANGULO: 132.080
*/

using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Informe os valores para A, B e C, respectivamente: ");
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0]);
            B = double.Parse(valores[1]);
            C = double.Parse(valores[2]);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}