// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
// casas decimais conforme exemplos.
// Fórmula: area = pi. raio²
// Considere o valor de π = 3.14159
using System;

class Program
{
    public static void Main()
    {
        Console.Write("Informe o valor do raio do círculo: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(raio, 2);

        Console.WriteLine($"A = {area:F4}");
    }
}
