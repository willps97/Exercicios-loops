using System;

/*Faça um algoritmo utilizando o comando while que mostra uma contagem regressiva na tela, iniciando em 10 e terminando
 em 0. Mostrar uma mensagem "FIM!" após a contagem*/

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;

            while(n > 0)
            {
                n -= 1;
                Console.WriteLine(n);

                if( n == 0)
                {
                    Console.WriteLine("FIM!");
                }
                
            }
        }
    }
}
