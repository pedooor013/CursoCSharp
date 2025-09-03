using System; // Parecido com o #include <stdio.h> do C, ele fornece comandos basicos para o C#
using System.Globalization;

namespace CursoCSharp //Cada function deve estar dentro de um namespace, para que assim seja mantido o padrao do C#
{
    internal class Program //Para que o codigo seja executado em C# ele deve estar dentro de uma CLASS, ela deve contem o mesmo nome do arquivo C#
    {
        static void Main(string[] args) //Apos essa operacao o C# entende que deve iniciar a compilacao do codigo
        {
            Console.WriteLine("Hello World!");
        }
    }
}
