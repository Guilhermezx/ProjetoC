using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Olá, qual operação deseja fazer?");
                Console.ReadLine();
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair\n");
                Console.WriteLine("Por favor, digite o numero da opção que deseja:");

                int menu = int.Parse(Console.ReadLine());

            switch (menu)
                {
                    case 1:
                    adicao();
                        Console.ReadLine();
                        break;

                    case 2:
                    subtracao();
                        Console.ReadLine();
                        break;

                    case 3:
                    multiplicacao();
                        Console.ReadLine();
                        break;

                    case 4:
                    divisao();
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Sua aplicação foi encerrada.");
                        Console.ReadLine();
                        break;

                  }

            void adicao()
            {
                Console.WriteLine("Você Escolheu a adição.");
                Console.WriteLine("\nPor favor, digite o primeiro numero:");
                    int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPor favor, digite o segundo numero:");
                    int num2 = int.Parse(Console.ReadLine());

                int resultado = 0;
                resultado = num1 + num2;

                Console.WriteLine("\nA sua soma é:");
                Console.Write(resultado);
                Console.ReadLine();
                Console.WriteLine("Deseja fazer outra pesquisa?");
            }

            void subtracao()
            {
                Console.WriteLine("Você Esoclheu a subtração");
                Console.WriteLine("\nPor favor, digite o primeiro numero:");
                    int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPor favor, digite o segundo numero:");
                    int num2 = int.Parse(Console.ReadLine());

                int resultado = 0;
                resultado = num1 - num2;

                Console.WriteLine("\nA Subtração é:");
                Console.Write(resultado);
                Console.ReadLine();
                Console.WriteLine("Deseja fazer outro calculo?");

            }

            void multiplicacao()
            {
                Console.WriteLine("Você Escolheu a Multiplicação.");
                Console.WriteLine("\nPor favor, digite o primeiro numero:");
                    float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nPor favor, digite o segundo numero:");
                    float num2 = float.Parse(Console.ReadLine());

                float resultado = 0;
                resultado = num1 * num2;

                Console.WriteLine("\nA sua multiplicação é:");
                Console.Write(resultado);
                Console.ReadLine();
                Console.WriteLine("Deseja fazer outra pesquisa?");

            }

            void divisao()
                {
                Console.WriteLine("Você Escolheu a Divisão.");
                Console.WriteLine("\nPor favor, digite o primeiro numero:");
                    float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("\nPor favor, digite o segundo numero:");
                    float num2 = float.Parse(Console.ReadLine());

                float resultado = 0;
                resultado = num1 / num2;

                Console.WriteLine("\n A sua multiplicação é:");
                Console.Write(resultado);
                Console.ReadLine();
                Console.WriteLine("Deseja fazer outra pesquisa?");
                }

        }
    }
}
