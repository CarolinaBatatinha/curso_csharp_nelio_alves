/*
Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
Exemplos:
Entrada:            Saída:
16 2                O JOGO DUROU 10 HORA(S)

Entrada:            Saída:
0 0                 O JOGO DUROU 24 HORA(S)

Entrada:            Saída:
2 16                O JOGO DUROU 14 HORA(S)
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a hora inicial do jogo: ");
        int horaInicial = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a hora final do jogo: ");
        int horaFinal = int.Parse(Console.ReadLine());
        int resultado;

        if (horaInicial < horaFinal)
        {
            resultado  = horaFinal - horaInicial;
            Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
        }
        else
        {
            resultado = 24 + horaFinal - horaInicial;
            Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
        }
    }
}