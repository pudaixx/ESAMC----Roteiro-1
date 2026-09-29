using System;

class Funcionario
{
    public string nome, cargo;

    public void Salario()
    {
        if (cargo == "Gerente") Console.WriteLine("R$10.000,00");
        else if (cargo == "Desenvolvedor") Console.WriteLine("R$5.000,00");
        else Console.WriteLine("R$100,00");
    }
}

class Program
{
    static void Main()
    {
        Funcionario f1 = new Funcionario();
        f1.nome = "João"; f1.cargo = "Gerente";

        Funcionario f2 = new Funcionario();
        f2.nome = "Pedro"; f2.cargo = "Desenvolvedor";

        Funcionario f3 = new Funcionario();
        f3.nome = "Lucas"; f3.cargo = "Estagiário";

        f1.Salario();
        f2.Salario();
        f3.Salario();
    }
}
