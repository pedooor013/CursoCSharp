using System;

namespace ExercicioEntradaDeDados;

class Program
{
    static void Main(string[] args)
    {
        string nomeUser;
        Console.WriteLine("Digite o seu nome inteiro: ");
        nomeUser = Console.ReadLine();
        int qntQuartos;
        Console.WriteLine("Digite a quantidade de quartos da sua casa: ");
        qntQuartos = int.Parse(Console.ReadLine());
        double precoProduto;
        Console.WriteLine("Digite o preço de um produto: ");
        precoProduto = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite na mesma linha o seu nome, idade, altura");
        string[] infoUser = Console.ReadLine().Split(' ');
        string ultimoNome = infoUser[0];
        int idadeUser = int.Parse(infoUser[1]);
        float alturaUser = float.Parse(infoUser[2]);
        
        //Imprimir no console as instruções

        //Imprimir dados digitados 
        Console.WriteLine("Itens digitados: ");
        Console.WriteLine(nomeUser);
        Console.WriteLine(qntQuartos);
        Console.WriteLine(precoProduto);
        Console.WriteLine(ultimoNome);
        Console.WriteLine(idadeUser);
        Console.WriteLine(alturaUser);
    }
}