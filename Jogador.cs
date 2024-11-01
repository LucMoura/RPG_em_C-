class Jogador{
    public string Nome {get; set;}
    public double Vida {get ; set;}
    public double Estamina {get; set;}
    public int Iventario {get ; set;}

    public void Atacar(){
        Estamina -= 10;
        Console.WriteLine("Ataque efetuado com sucesso");
    }
    public void Morrer(){
        Vida = 0;
        Console.WriteLine("Você morreu");
    }

    public void Correr(){
        Estamina -= 2;
    }
    
    public void Esquivar(){
        Estamina -= 5;
    }
    public double GetVida(){
        return Vida;
    }

    public string GetNome(){
        return Nome;
    }

    public void ReceberDano(double dano){
        Vida -= dano;
        if (Vida <= 0)
        {
            Morrer();
        }
    }
}
