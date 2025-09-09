using System;

namespace PrecoComArray;

class Program
{
    static void Main(string[] args)
    {
        string[] produto1, produto2;

        produto1 = Console.ReadLine().Split(' ');
        
        int codigoProduto1 = int.Parse(produto1[0]);
        int qntProduto1 = int.Parse(produto1[1]);   
        double precoProduto1 = double.Parse(produto1[2]);
        
        produto2 = Console.ReadLine().Split(' ');
        int codigoProduto2 = int.Parse(produto2[0]);
        int qntProduto2 = int.Parse(produto2[1]);   
        double precoProduto2 = double.Parse(produto2[2]);

        double vlrFinal = (precoProduto1 * qntProduto1) + (precoProduto2 * qntProduto2);
        Console.WriteLine($"Valor final R${vlrFinal}");
    }
}
