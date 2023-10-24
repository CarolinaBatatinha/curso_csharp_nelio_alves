﻿/*
Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0). Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
Exemplos:
Entrada:        Saída:
4.5 - 2.2       Q4
Entrada:        Saída:
0.1 0.1         Q1
Entrada:        Saída:
0.0 0.0         Origem
*/

using System;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Digite o valor de x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y:");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x> 0 && y>0)
            {
                Console.WriteLine("Q1");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("Q3");
            }
        }
    }
}