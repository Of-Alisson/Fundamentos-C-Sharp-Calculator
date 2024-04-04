using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oque deseja?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - sair");

            Console.WriteLine("--------");

            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Soma();
                break;
                case 2: Subtracao();
                break;
                case 3: Divisao();
                break;
                case 4: Multiplicacao();
                break;
                case 5: System.Environment.Exit(0);
                break;
                default:Menu();
                break;
            }


        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double r = v1 + v2;

            Console.WriteLine($"O Resultado da Soma é:{r}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
             Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double r = v1 - v2;

            Console.WriteLine($"O Resultado da Subtração é:{r}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
             Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double r = v1 * v2;

            Console.WriteLine($"O Resultado da Multiplicação é:{r}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
             Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double r = v1/v2;

            Console.WriteLine($"O Resultado da Divisão é:{r}");
            Console.ReadKey();
            Menu();
        }
    }

}
