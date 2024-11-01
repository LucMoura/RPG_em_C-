class Arqueiro : Jogador{
    public double Destreza{set; get;}
    public double Agilidade{set; get;}
    public Arqueiro(string nome){
        Nome = nome;
        Vida = 50;
        Estamina = 100;
        Destreza = 50;
        Agilidade = 40;
    }

    public void atirar(){
        Destreza += 10;
        Agilidade += 1;
        Estamina -= 2;
    }
}


class Arqueiro_de_Fogo : Arqueiro{
    public Arqueiro_de_Fogo(string nome) : base(nome)
    {
    }

    protected int Flecha_Fogosas {set; get;}
    protected void Chuva_de_Flechas_Flamejantes(){
        if (Estamina <= 10 && Destreza > 2){
            Console.WriteLine("Chuva de flechas atirada");
            Estamina -= 25;
            Destreza += 0.5;
            Agilidade += 0.1;
            Flecha_Fogosas -= 5;
        }else {
            Console.WriteLine("Sem estamina");
        }
    }
}


class Arqueiro_Venenoso : Arqueiro{
    public Arqueiro_Venenoso(string nome) : base(nome)
    {
    }

    protected int Flecha_Venenosa {set; get;}
        protected void Chuva_de_Flechas_Venenosas(){
            if (Estamina <= 10 && Destreza > 2){
                Console.WriteLine("Chuva de flechas atirada");
                Estamina -= 25;
                Destreza += 0.5;
                Agilidade += 0.1;
                Flecha_Venenosa -= 5;
            }else{
                if (Estamina <= 10){
                    Console.WriteLine("Está com pouca estamina");
                } else{
                    Console.WriteLine("Não tens destreza o bastante");
                }
            }
        }
}
