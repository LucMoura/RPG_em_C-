class Guerreiro : Jogador{
    public double Defesa{set; get;}
    public double Força{set; get;}
    public Guerreiro(string nome){
        Nome = nome;
        Vida = 70;
        Estamina = 50;
        Defesa = 50;
        Força = 45;
    }
    public void bloquar(){
        Defesa -= 5;
        Estamina -= 10;
        Console.WriteLine("Defesa");
    }
}

class Pistoleiro : Guerreiro{
    public Pistoleiro(string nome) : base(nome)
    {
    }

    protected int Municao {set; get;}
    public void Atirar(){
        Municao -= 1;
        Console.WriteLine("POw");
    } 
}

class Espadachim : Guerreiro{
    public Espadachim(string nome) : base(nome)
    {
    }

    protected string Espada {set; get;}
    protected int Vida_Espada {set; get;}
    public void Espada_especial(){
        Console.WriteLine($"A sua espada {Espada} acertou o inimigo, chuin");
        Vida_Espada -= 1;
    }
}
