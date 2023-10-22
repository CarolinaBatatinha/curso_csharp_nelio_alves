/*
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.
Exemplos:
Entrada:            Saída:
6 24                Sao Multiplos

Entrada:            Saída:
6 25                Nao sao Multiplos

Entrada:            Saída:
24 6                Sao Multiplos
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor de A: ");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor de B: ");
        int B = int.Parse(Console.ReadLine());

        if (A % B == 0 || B % A == 0)
        {
            Console.WriteLine("São múltiplos");
        }
        else
        {
            Console.WriteLine("Não são múltiplos");
        }
    }
}