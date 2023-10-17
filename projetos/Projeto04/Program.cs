using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();
        Console.WriteLine("Digite uma cor: ");
        string x = Console.ReadLine();
        Console.WriteLine("Digite outra cor: ");
        string y = Console.ReadLine();
        Console.WriteLine("Digite a última cor: ");
        string z = Console.ReadLine();

        Console.WriteLine("Digite três cores na mesma linha: ");

        string[] vetor = Console.ReadLine().Split(' ');
        string a = vetor[0];
        string b = vetor[1];
        string c = vetor[2];

        Console.WriteLine("Você digitou: ");
        Console.WriteLine(frase);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}