// Exercício 3.2:
// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
// essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
// Exemplos:
// Entrada:        Saída:
// 5               2 in
// 14              3 out
// 123
// 10
// -25
// 32

// Entrada:        Saída:
// 4               1 in
// 86              3 out
// 35
// 20
// 7

Console.WriteLine("Digite o número de valores inteiros a serem lidos: ");
int num = Convert.ToInt32(Console.ReadLine());
int noIntervalo = 0;
int foraIntervalo = 0;


for (int i = 0; i < num; i++)
{
    Console.WriteLine($"Digite o {i + 1}º valor: ");
    int valor = Convert.ToInt32(Console.ReadLine());

    if (valor >= 10 && valor <= 20)
    {
        noIntervalo ++;
    }
    else{
        foraIntervalo++;
    }
}

Console.WriteLine($"{noIntervalo} in");
Console.WriteLine($"{foraIntervalo} out");