using System;

namespace Projeto05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split();

            string sobrenome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}