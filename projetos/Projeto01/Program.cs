using System;
using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'F';
double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos:");
Console.WriteLine($"{produto1}, cujo preço é R$ {preco1:F2}");
Console.WriteLine($"{produto2}, cujo preço é R$ {preco2:F2}\n");
Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");
Console.WriteLine($"Medida com 8 casas decimais: {medida:F8} ");
Console.WriteLine($"Arredondado (trẽs casas decimais): {medida:F3} ");
Console.WriteLine("Separador decimal invariant culture: ", medida.ToString("F3", CultureInfo.InvariantCulture));