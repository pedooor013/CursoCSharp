using System;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            
            //Tipos de dados mais usados em C#

            bool completo = false;
            string nome = "Vitoria";
            char genero = 'F';
            byte n1 = 126;
            int n2 = 2147483647;
            long n3 = 2147483648L;
            float n4 = 4.5f; //Para o C# identificar que o float eh mesmo um float, deve conter o f no final do numero,
                             //caso contrario ele eh identificado como double
            double n5 = 4.58654;
            object obj1 = "Pedro Lopes"; //Toda classe em C# eh uma classe object generica             
            object obj2 = 6.8f; //Object aceita QUALQUER tipo de dado
            
            Console.WriteLine(completo);
            Console.WriteLine(nome);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            //Testes com MinValue e MaxValue
            int nTeste = int.MinValue;
            int nTeste2 = int.MaxValue;
            sbyte nTeste3 = sbyte.MinValue;
            decimal nTeste4 = decimal.MaxValue;
            
            Console.WriteLine(nTeste);
            Console.WriteLine(nTeste2);
            Console.WriteLine(nTeste3);
            Console.WriteLine(nTeste4);
            
            //Exemplo de exibição no console
            
            Console.Write("Imprime no console a mensagem entre aspas duplas, porem nao adiciona quebra de linha");
            Console.WriteLine("Escreve no console a mensagem entre aspas duplas, e adiciona uma quebra de linha");

            //Como controlar a quantidade de casas do numero double
            Console.WriteLine(n5.ToString("F2"));


        }
    }
};