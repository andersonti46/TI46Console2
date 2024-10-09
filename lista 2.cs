using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class lista2
    {
        public static void escolherExercicio()
        {
            nome();
        }

        private static void nome()
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Programa nome");
            Console.WriteLine("2 - nome 1 da lista");
            Console.WriteLine("3 - escolher numeros");
            Console.WriteLine("4 - tabuada");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    exercicio1();
                    break;

                    case 2:
                    exercicio2();
                    break;

                    case 3:
                    exercicio3();
                    break;

                    case 4:
                    exercicio4();
                    break;
                
            }



           



            // lista exercicio 6

            Console.WriteLine("Digite um número para ver sua tabuada:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");

            }

        }

        private static void exercicio1()
        {
            throw new NotImplementedException();
        }

        private static void exercicio2()
        {
            int inicio = 35;
            int fim = 98111;
            int contadorPares = 0;

            // Começamos do próximo número par após o início
            int numeroAtual = inicio + (inicio % 2 == 0 ? 0 : 1);

            while (numeroAtual <= fim)
            {
                contadorPares++;
                numeroAtual += 2;
            }

            Console.WriteLine($"A quantidade de números pares entre {inicio} e {fim} é: {contadorPares}");

            Console.ReadKey();
        }

        private static void exercicio4()
        {
            
        }

        private static void exercicio3()
        {
            //lista1 exercicio 3

            string nome;

            do
            {
                Console.Write("Digite um nome (ou 'João' para sair): ");
                nome = Console.ReadLine();
            } while (nome != "João");

            Console.WriteLine("Você digitou João! O programa será encerrado.");
            Console.ReadKey();
        }
    }
    }

