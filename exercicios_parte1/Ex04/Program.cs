/*
Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.
Exemplos:
Entrada:            Saída:
25                  NUMBER = 25
100                 SALARY = U$ 550.00
5.50

Entrada:            Saída:
1                   NUMBER = 1
200                 SALARY = U$ 4100.00
20.50

Entrada:            Saída:
6                   NUMBER = 6
145                 SALARY = U$ 2254.75
15.55
*/

using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número do funcionário: ");
            int numFuncionario = int.Parse(Console.ReadLine());
            Console.Write("Informe o número de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor recebido por hora: ");
            double valorPorHora = double.Parse(Console.ReadLine());

            double salario = horasTrabalhadas * valorPorHora;
            
            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.WriteLine($"SALARY = U$ {salario:F2}");
        }
    }
}

