using System;

namespace RaioCirculo;

class Program
{
    static void Main(string[] args)
    {
        double raio, area, pi = 3.14159;

        Console.WriteLine("Digite o valor do raio");
        raio = double.Parse(Console.ReadLine());

        area = (raio*raio) * pi;

        Console.WriteLine($"A area de um circulo com raio de {raio} eh igual a {area}");


    }
} 