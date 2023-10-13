// Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (􀀁􀀋􀀊 + 􀀍􀀋 + 􀀎 = 0)
// Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja
// abaixo). Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
// negativo), mostrar uma mensagem "Impossivel calcular".
// Fórmula: x= 􀀐􀀑±√Δ
// 􀀊􀀕 onde: Δ= 􀀍􀀊 − 4􀀁􀀎

Console.Write("Digite o valor de a: ");
double valorA = Convert.ToDouble(Console.ReadLine());

if (valorA == 0)
{
    Console.WriteLine("Impossível calcular");
}
else
{
    Console.Write("Digite o valor de b: ");
    double valorB = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite o valor de c: ");
    double valorC = Convert.ToDouble(Console.ReadLine());

    double delta = Math.Pow(valorB, 2) - (4 * valorA * valorC);

    if (delta < 0)
    {
        Console.WriteLine("Impossível calcular");
    }
    else 
    {
        double x1 = ( -valorB + Math.Sqrt(delta))/ (2 * valorA);
        double x2 = ( -valorB - Math.Sqrt(delta))/(2 * valorA);

        Console.WriteLine($"X1 = {x1:F5}");
        Console.WriteLine($"X2 = {x2:F5}");
    }
}
