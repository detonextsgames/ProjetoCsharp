using System;
namespace calculadora{ //Calculadora Simples C#
    internal class Program{
        static void Main(string[] args)
        { 
            //var
            int num1, num2;
            float soma, sub, mult, div;

            Console.WriteLine("===----------CALCULADORA SIMPLES----------===");

            Console.WriteLine("Digite um Numero: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite outro Numero: ");
            num2 = int.Parse(Console.ReadLine());

            //Resultado
            soma = (num1 + num2);
            sub = (num1 - num2);
            mult = (num1 * num2);
            div = (num1 / num2);

            //resultado
            Console.WriteLine($"\nA Soma de {num1} + {num2} = " + soma);
            Console.WriteLine($"\nA Subtração de {num1} - {num2} = " + sub);
            Console.WriteLine($"\nA Multiplicação de {num1} * {num2} = " + mult);
            Console.WriteLine($"\nA Divisão de {num1} / {num2} = " + div);

            Console.WriteLine("\n------------------------------------------\n");
        }
    }
}