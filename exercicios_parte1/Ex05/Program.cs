/*

Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
Exemplos:
Entrada:            Saída:
12 1 5.30           VALOR A PAGAR: R$ 15.50
16 2 5.10

Entrada:            Saída:
13 2 15.30          VALOR A PAGAR: R$ 51.40
161 4 5.20

Entrada:            Saída:
1 1 15.10           VALOR A PAGAR: R$ 30.20
2 1 15.10

*/

using System;
namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o código da peça 1: ");
            int peca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de peças 1: ");
            int qtdePeca1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário da peça 1: ");
            double valorPeca1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o código da peça 2: ");
            int peca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de peças 2: ");
            int qtdePeca2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor unitário da peça 2: ");
            double valorPeca2 = double.Parse(Console.ReadLine());

            double aPagar = (qtdePeca1 * valorPeca1) + (qtdePeca2 * valorPeca2);

            Console.WriteLine($"VALOR A PAGAR: R$ {aPagar:F2}");
        }
    }
}