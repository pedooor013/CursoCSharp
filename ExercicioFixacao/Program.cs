using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis 
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";
            
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preco eh R${preco1}");
            Console.WriteLine($"{produto2}, cujo preco eh R${preco2}");

            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero:  {genero}");

            Console.WriteLine($"Medida com outro casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (tres casas decimais): { medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture " + medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}