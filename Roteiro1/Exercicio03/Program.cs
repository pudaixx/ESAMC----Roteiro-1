using System;

class Produto
{
    public string nome;
    public double preco;
    public int quantidade;

    public void ExibirDados()
    {
        Console.WriteLine(nome + " " + preco + " " + quantidade);
    }

    public double CalcularValorTotal()
    {
        return preco * quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto p1 = new Produto();
        p1.nome = "Arroz"; p1.preco = 20; p1.quantidade = 2;

        Produto p2 = new Produto();
        p2.nome = "Feijão"; p2.preco = 10; p2.quantidade = 3;

        Produto p3 = new Produto();
        p3.nome = "Macarrão"; p3.preco = 5; p3.quantidade = 4;

        p1.ExibirDados(); Console.WriteLine(p1.CalcularValorTotal());
        p2.ExibirDados(); Console.WriteLine(p2.CalcularValorTotal());
        p3.ExibirDados(); Console.WriteLine(p3.CalcularValorTotal());
    }
}
