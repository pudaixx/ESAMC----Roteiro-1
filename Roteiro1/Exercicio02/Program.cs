using System;

class Fantasma
{
    public string habilidade, nick, cor;

    public void GerarFantasma()
    {
        Console.WriteLine(habilidade + " " + nick + " " + cor);
    }

    public void Mover(string direcao)
    {
        Console.WriteLine(nick + " se moveu para " + direcao);
    }
}
