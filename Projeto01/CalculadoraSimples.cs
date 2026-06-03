using System;
namespace calculadora{ //Calculadora Simples C#
    internal class Program{
        static void Main(string[] args)
        { 
            //var
            int num1, num2, soma;

            Console.WriteLine("===----------CALCULADORA SIMPLES----------===");

            Console.WriteLine("Digite um Numero: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro Numero: ");
            num2 = int.Parse(Console.ReadLine());

            //soma
            soma = (num1 + num2);

            //resultado
            Console.WriteLine($"\nA Soma de {num1} + {num2} = " + soma);

        }
    }
}