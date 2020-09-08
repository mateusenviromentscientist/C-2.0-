using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }    

        static void Menu (){
            Console.Clear();
            Console.WriteLine("O que deseja fazer");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());
            switch (res) {
                case 1 : Soma();break;
                case 2 : Diferenca();break;
                case 3 : Divisao();break;
                case 4 : Multiplicacao();break;
                case 5 : System.Environment.Exit(0);break;
                default: Menu();break;
            }
        }
        static void Soma (){
            Console.Clear();
            Console.WriteLine("Digite os valores para realizar a soma");
            float v1 = float.Parse(Console.ReadLine());
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine( "o resultado da soma é " + (v1 + v2));
            Console.ReadKey();
            Menu();
        }
        static void Diferenca(){            
            Console.Clear();
            Console.WriteLine("Digite os valores para realizar a subtração");
            float v1 = float.Parse(Console.ReadLine());
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da diferença é " + (v1 - v2));
            Console.ReadKey();
            Menu();
        }
        static void Divisao(){
            Console.Clear();
            Console.WriteLine("Digite os valores para realizar a divisão");
            float v1 = float.Parse(Console.ReadLine());
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da divisão é " + (v1/v2));
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao(){
            Console.Clear();
            Console.WriteLine("Digite os valores para realizar a multiplicação");
            float v1 = float.Parse(Console.ReadLine());
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("O resultado da multiplicação é " + (v1 * v2));
            Console.ReadKey();
            Menu();        
        }
    }
}
