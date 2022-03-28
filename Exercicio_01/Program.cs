using System;

/*Faça um programa que determine e mostre os cinco primeiro múltiplos de 3, considerando números maiores que 0*/

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            for (int i = 1; i <= 5; i++)
            {

                n = 3 * i;

                Console.WriteLine(n);
            }
            
        }
    }
}
