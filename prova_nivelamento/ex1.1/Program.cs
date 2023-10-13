// Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
// código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

using System;

class Program
{
    public static void Main()
    {
        Console.Write("Informe o código da peça 1: ");
        int codigo1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o número de peças da peça 1: ");
        int numeroPecas1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o valor unitário da peça 1: ");
        float valorUnitario1 = float.Parse(Console.ReadLine());

        Console.Write("Informe o código da peça 2: ");
        int codigo2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o número de peças da peça 2: ");
        int numeroPecas2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o valor unitário da peça 2: ");
        float valorUnitario2 = float.Parse(Console.ReadLine());

        float valorTotal = (numeroPecas1 * valorUnitario1) + (numeroPecas2 * valorUnitario2);

        Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");
    }
}
