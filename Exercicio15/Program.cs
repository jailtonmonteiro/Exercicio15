/*
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/

using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int cIn = 0, cOut = 0, n, x;

            Console.Write("Digite a quantidade de valores: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o valor {i}:");
                x = int.Parse(Console.ReadLine());

                if( x >= 10 &&  x <= 20)
                {
                    cIn++;
                }
                else
                {
                    cOut++;
                }
            }

            Console.WriteLine($"{cIn} in");
            Console.WriteLine($"{cOut} out");
        }
    }
}