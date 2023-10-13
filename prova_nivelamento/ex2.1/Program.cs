// Com base na tabela de preços ao lado, faça
// um programa que leia o código de um item e a
// quantidade deste item. A seguir, calcule e
// mostre o valor da conta a pagar.

Console.Write("Digite o código do item: ");
int codigo = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe a quantidade desse item: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

if (codigo == 1)
{
    double valorConta = quantidade * 4;
    Console.WriteLine($"TOTAL: R$ {valorConta:F2}");
}
else if (codigo == 2)
{
    double valorConta = quantidade * 4.5;
    Console.WriteLine($"TOTAL: R$ {valorConta:F2}");
}
else if (codigo == 3)
{
    double valorConta = quantidade * 5;
    Console.WriteLine($"TOTAL: R$ {valorConta:F2}");
}
else if (codigo == 4)
{
    double valorConta = quantidade * 2;
    Console.WriteLine($"TOTAL: R$ {valorConta:F2}");
}
else if (codigo == 5)
{
    double valorConta = quantidade * 1.5;
    Console.WriteLine($"TOTAL: R$ {valorConta:F2}");
}
else
{
    Console.WriteLine("Informe um código válido");
}
