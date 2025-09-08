using System;

namespace Soma;

class Program
{
    static void Main(string[] args)
    {
        int num1, num2, result;

        Console.WriteLine("Digite o valor de um numero: ");     
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor de um numero: ");
        num2 = int.Parse(Console.ReadLine());

        result = num1 + num2;
        
        Console.WriteLine($"SOMA = {result}");
    }

}