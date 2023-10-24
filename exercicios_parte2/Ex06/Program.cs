/*
 Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
Exemplos:
Entrada:        Saída:
25.01           Intervalo(25, 50]

Entrada:        Saída:
25.00           Intervalo[0, 25]

Entrada:        Saída:
100.00          Intervalo(75, 100]

Entrada:        Saída:
-25.02          Fora de intervalo*/

using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double numero = double.Parse(Console.ReadLine());

            if (numero > 25 && numero <= 50)
            {
                Console.WriteLine("Intervalo (25, 50)");
            }
            else if (numero > 0 && numero <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if(numero >= 75 &&  numero <= 100) 
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}