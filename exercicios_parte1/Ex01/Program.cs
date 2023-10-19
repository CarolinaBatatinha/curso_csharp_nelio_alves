//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
//mensagem explicativa, conforme exemplos. Exemplos:
//Entrada:            Saída:
//10                  SOMA = 40
//30

//Entrada:            Saída:
//-30                 SOMA = -20
//10

//Entrada:            Saída:
//0                   SOMA = 0
//0

using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {n1 + n2}");
        }
    }
}
