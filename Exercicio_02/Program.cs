using System;

/*Escreva um programa que printe na tela de um até 100, de 1 em 1, duas vezes. A primeira vez deve usar a estrutura de 
 * repetição for. e a segunda while.
 */

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------------------------------------");

            int j = 0;

            while(j < 100)
            {
                j += 1;

                Console.WriteLine(j);
            }
        }
    }
}
