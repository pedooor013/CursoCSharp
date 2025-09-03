using System;

namespace ConversaoImplicitaECasting;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Conversão implicitamente
         * Casting: É a conversão explicita entre tipos COMPÁTIVEIS
         */
        
        //É possível converter float (4 bytes) em double (8 bytes)
        float x = 4.5f; 
        double y = x;
        
        Console.WriteLine(y);

        //Porem não é possivel converter de forma implicita o double(8 bytes) em float(4 bytes)
        double a = 5.1;
        float b = (float)a;
                //   ^-- Casting, demonstra ao compilador que você deseja que o valor a possa perder valor para virar float;    

        Console.WriteLine(b);

        double c = 8.19;
        int d = (int)c;
        //Foi retornado 8, ou seja ocorreu a perca de informação 

        Console.WriteLine(d);
        
        //Divisão int com resultado double

        int div1 = 5;
        int div2 = 2;
        
        double resultDiv3 = (double)div1 / div2;
        //Caso não seja feito o casting o resultado de double é igual a divisão inteira da nota

        Console.WriteLine(resultDiv3);

    }
}