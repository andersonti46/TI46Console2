using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Programa média");
            Console.WriteLine("2 - Exercício 1 da lista");
            Console.WriteLine("3 - Exercício 2 da lista");


            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    lista1.escolherExercicio();
                    break;

                case 2:
                    lista2.escolherExercicio();
                    break;

                case 3:
                    lista3.Exercicio();

                    break;
                case 4:

                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
