using System;

namespace EntradaDeDados;

class Program
{
    static void Main(string[] args)
    {
        /*
        //ReadLine trata TODOS como string
        string frase, x, y, z, a, b, c;
        string s;
        frase = Console.ReadLine();
        x = Console.ReadLine();
        y = Console.ReadLine();
        z = Console.ReadLine();
        Console.WriteLine(frase);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        
        //Split, formado na seguinte estrutura
        //string[] vet = Variavel.Split(' ');
                                       //^-- Digitar aqui o que deve "separar" as
                                        //palavras
        s =  Console.ReadLine();
        
        string[] v = Console.ReadLine().Split(' ');
        
        a = v[0];
        b = v[1];
        c = v[2];
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        */
        
        //Ler int

        int n1 = int.Parse(Console.ReadLine());
        
        //Ler char
        
        char ch = char.Parse(Console.ReadLine());
        
        //Ler double
        double db = double.Parse(Console.ReadLine());
        
        //Ler float
        float f = float.Parse(Console.ReadLine());
        
        //Ler String

        string[] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        
        
        Console.WriteLine("Você digitou: ");
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(db);
        Console.WriteLine(f);
        
    }
}