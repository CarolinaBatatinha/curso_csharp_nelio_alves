/*
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar.

CÓDIGO          ESPECIFICAÇÃO           PREÇO
1               cachorro quente         R$ 4.00
2               x-salada                R$ 4.50
3               x-bacon                 R$ 5.00
4               torrada simples         R$ 2.00
5               refrigerante            R$ 1.50

Exemplos:
Entrada:                Saída:
3 2                     Total: R$ 10.00

Entrada:                Saída:
2 3                     Total: R$ 13.50
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o código do item: ");
        int codigo = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade do item selecionado: ");
        int quantidade = int.Parse(Console.ReadLine());
        double valorFinal = 0;

        if (codigo == 1)
        {
            valorFinal = quantidade * 4;
        }
        else if (codigo == 2)
        {
            valorFinal = quantidade * 4.5;
        }
        else if (codigo == 3)
        {
            valorFinal = quantidade * 5;
        }
        else if (codigo == 4)
        {
            valorFinal = quantidade * 2;
        }
        else if (codigo == 5)
        {
            valorFinal = quantidade * 1.5;
        }
        Console.WriteLine($"Total: R$ {valorFinal:F2}");
    }
}