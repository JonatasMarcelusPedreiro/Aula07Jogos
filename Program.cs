using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Jogos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteador = new Random();

            int numero;
            int sorteio = sorteador.Next(1, 11);

            Console.WriteLine(" Bem-vindos a conraditos Jogos");
            Console.WriteLine(" Adivinhe o número de 1 até 10");
            Console.WriteLine(" Digite o número");
            numero = Int32.Parse (Console.ReadLine());


            



           
             if ( numero == sorteio)
            {
                Console.WriteLine(" Parabéns, você acertou o número e ganhou!");




            }else
            {

                Console.WriteLine(" Que pena, você errou! Tente novamente...");
                
                return;


            }


            Console.ReadKey();




        }
    }
}
