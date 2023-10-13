// Exercício 3.1:
// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
// Exemplos:
// Entrada:            Saída:
// 2200                Senha Invalida
// 1020                Senha Invalida
// 2022                Senha Invalida
// 2002                Acesso Permitido

// Entrada:            Saída:
// 2020                Senha Invalida
// 1031                Senha Invalida
// 2002                Acesso Permitido

int senhaValida = 2002;

while(true)
{
    Console.Write("Informe sua senha de 4 dígitos: ");
    int senhaDigitada = Convert.ToInt32(Console.ReadLine());

    if (senhaDigitada == senhaValida)
    {
        Console.WriteLine("Acesso permitido");
        break;
    }
    else
    {
        Console.WriteLine("Senha Invalida");
    }
}


