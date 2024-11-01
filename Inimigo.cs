class Inimigo
{
    public string Nome { get; set; }
    public double Vida { get; set; } = 50;

    public Inimigo(string nome)
    {
        Nome = nome;
    }

    public void Atacar(Jogador jogador)
    {
        Console.WriteLine($"{Nome} atacou {jogador.GetNome}!");
        jogador.ReceberDano(10);
    }
}