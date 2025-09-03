// See https://aka.ms/new-console-template for more information
namespace OperadoresAtribuicao;

class Program   
{
    static void Main(string[] args)
    {
        /*_______________________________________
         *| OPERADOR | EXEMPLO  | SISGNIFICADO    |
         *|     =    | a = 10   | a RECEBE 10     |
         *|    +=    | a += 10  | a RECEBE a + 10 |
         *|    -=    | a -= 10  | a RECEBE a - 10 |
         *|    *=    | a *= 10  | a RECEBE a * 10 |
         *|    /=    | a /= 10  | a RECEBE a / 10 |
         *|    %=    | a %= 10  | a RECEBE a % 10 |
         * ---------------------------------------
         */

        int a = 10;
        Console.WriteLine(a);

        a += 2;
        Console.WriteLine(a);

        a -= 4;
        Console.WriteLine(a);
         
        a *= 3;
        Console.WriteLine(a);
         
        //O += serve para concatenar string

        string s = "ABC";
        Console.WriteLine(s);
         
        s += "DEF";
        Console.WriteLine(s);

        //Operadores de incrementacao 

        int adicao = 10;
        Console.WriteLine($"Original: {adicao}");
        adicao++;
        Console.WriteLine($"Usando o operador ++ : {adicao}");

        int subtracao = 15;
        Console.WriteLine($"Original: {subtracao}");
        subtracao--;
        Console.WriteLine($"Usando o operador -- : {subtracao}");


    }
}