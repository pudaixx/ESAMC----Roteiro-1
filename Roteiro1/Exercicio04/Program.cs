using System;

class ContaBancaria
{
    public string titular;
    public int numeroConta;
    public double saldo;

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor <= saldo) saldo -= valor;
    }

    public void ExibirSaldo()
    {
        Console.WriteLine(saldo);
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria c1 = new ContaBancaria();
        c1.titular = "João"; c1.numeroConta = 1;
        c1.Depositar(1000);
        c1.Sacar(300);
        c1.ExibirSaldo();

        ContaBancaria c2 = new ContaBancaria();
        c2.titular = "Pedro"; c2.numeroConta = 2;
        c2.Depositar(500);
        c2.Sacar(200);
        c2.ExibirSaldo();
    }
}
