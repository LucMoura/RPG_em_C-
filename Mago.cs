class Mago : Jogador{
    protected double Mana{set; get;}
    protected double Conhecimento {set; get;}
    public Mago(string nome){
        Nome = nome;
        Vida = 40;
        Estamina = 40;
        Mana = 150;
    }
    public void usar_magia(){
        Mana -= 5;
        Conhecimento += 2;
        Estamina -= 2;
        Console.WriteLine("Mágia lançada");

    }
}

class Mago_Terra : Mago{
    public Mago_Terra(string nome) : base(nome)
    {
    }

    public void Magia_Terra(){
        Mana -= 3;
        Estamina -= 1;
        Conhecimento += 2.5;
        if (Conhecimento >= 10){
            Console.WriteLine("Seu conhecimento alto lhe trouxe vantagens");
            Estamina += 2;
        }else {
            Console.WriteLine("Golpe Efetuado com sucesso");
        }
    }
}

class Mago_Agua : Mago{
    public Mago_Agua(string nome) : base(nome)
    {
    }

    public void Magia_Agua(){
        Mana -= 3;
        Estamina -= 1;
        Conhecimento += 2.5;
         if (Conhecimento >= 10){
            Console.WriteLine("Seu conhecimento alto lhe trouxe vantagens");
            Estamina += 2;
        }else {
            Console.WriteLine("Golpe Efetuado com sucesso");
        }


    }
}
