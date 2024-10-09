using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class lista3
    {


        public static void Exercicio()
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1 - Programa nome");
            Console.WriteLine("2 - Exercicio-1");
            Console.WriteLine("3 - Exercicio-2");
            Console.WriteLine("4 - Exercicio-3");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    exercicio1();

                    break;

                    case 2:
                    execicio2();
                    break;

                    case 3:
                    exercicio3();
                    break;




            }
        }

        private static void exercicio3()
        {
            // Declaração das variáveis
            int A, B, C, soma;

            // Entrada de dados
            Console.Write("Digite o valor de A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            C = Convert.ToInt32(Console.ReadLine());


            // Cálculo da soma
            soma = A + B;

            // Comparação e saída
            if (soma < C)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A + B não é menor que C.");
            }
        }


        private static void execicio2()
        {
            // Pedir ao usuário para digitar um número
            Console.Write("Digite um número: ");

            // Ler o número digitado e convertê-lo para um inteiro
            int numero = Convert.ToInt32(Console.ReadLine());

            // Comparar o número com 10 e imprimir a mensagem correspondente
            if (numero > 10)
            {
                Console.WriteLine("É MAIOR QUE 10!");
            }
            else
            {
                Console.WriteLine("NÃO É MAIOR QUE 10!");
            }
        }

        public static void exercicio1()
        {
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if
              (numero > 20)
            {
                Console.WriteLine("O número " + numero + " é maior que 20.");
            }
        }
    }
}



