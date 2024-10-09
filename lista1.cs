using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class lista1
    {
        public static void escolherExercicio()
        {
            //exercicio1();

            exercicio2();
        }

        private static void exercicio2()
        {
            
            
                // Declaração das variáveis para armazenar as notas e a média
                double nota1, nota2, nota3, nota4, media;

                // Solicita ao usuário que digite as notas
                Console.WriteLine("Digite a primeira nota:");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota:");
                nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota:");
                nota3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a quarta nota:");
                nota4 = Convert.ToDouble(Console.ReadLine());

                // Cálculo   

                media = (nota1 + nota2 + nota3 + nota4) / 4;

                // Exibição do resultado
                Console.WriteLine("A média é: " + media);
            
        }

        private static void exercicio1()
        {
            // Declaração das variáveis para armazenar os valores
            double valor1, valor2, valor3, resultado;

            // Solicita os valores ao usuário
            Console.WriteLine("Digite o primeiro valor:");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");

            valor3 = Convert.ToDouble(Console.ReadLine());

            // Calcula a soma
            resultado = valor1 + valor2 + valor3;

            // Exibe o resultado
            Console.WriteLine("A soma dos valores é: " + resultado);
            Console.ReadKey();
        }

        internal static void escolhernome()
        {
            throw new NotImplementedException();
        }
    }
}
