Console.Clear();

Console.WriteLine("Olá jogador, qual é o seu nome?");
string nome = Console.ReadLine();

Jogador jogador = null;

Console.WriteLine($"Olá {nome}, qual classe você deseja ser?\n1- Mago\n2- Arqueiro\n3- Guerreiro");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Perfeito, tem interesse em ser um mago com alguma especialidade?\n1- Sim, quero ser um mago de terra\n2- Sim quero ser um mago de água\n3- Não");
        int escolha_mago = int.Parse(Console.ReadLine());
        switch (escolha_mago)
        {
            case 1:
                Console.WriteLine("Ótima escolha");
                jogador = new Mago_Terra(nome);
                break;
            case 2:
                Console.WriteLine("Ótima escolha");
                jogador = new Mago_Agua(nome);
                break;
            case 3:
                Console.WriteLine("Tudo bem!");
                jogador = new Mago(nome);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        break;
    case 2:
        Console.WriteLine("Ótimo, qual tipo de arqueiro você deseja ser?\n1- Arqueiro de Fogo\n2- Arqueiro de Veneno\n3- Arqueiro padrão");
        int escolha_arqueiro = int.Parse(Console.ReadLine());
        switch (escolha_arqueiro)
        {
            case 1:
                Console.WriteLine("Ótima escolha!");
                jogador = new Arqueiro_de_Fogo(nome);
                break;
            case 2:
                Console.WriteLine("Ótima escolha!");
                jogador = new Arqueiro_Venenoso(nome);
                break;
            case 3:
                Console.WriteLine("Tudo bem!");
                jogador = new Arqueiro(nome);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        break;
    case 3:
        Console.WriteLine("Ótima escolha!\nDeseja ser qual tipo de guerreiro?\n1- Espadachim\n2- Pistoleiro\n3- Guerreiro padrão");
        int escolha_guerreiro = int.Parse(Console.ReadLine());
        switch (escolha_guerreiro)
        {
            case 1:
                Console.WriteLine("Ótimo!");
                jogador = new Espadachim(nome);
                break;
            case 2:
                Console.WriteLine("Ótimo!");
                jogador = new Pistoleiro(nome);
                break;
            case 3:
                Console.WriteLine("Tudo bem!");
                jogador = new Guerreiro(nome);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

if (jogador != null)
{
    Inimigo inimigo = new Inimigo("Orc");

    Console.WriteLine("\nInício do combate!");

    while (jogador.GetVida() > 0 && inimigo.Vida > 0)
    {
        Console.WriteLine("\nEscolha sua ação:");
        Console.WriteLine("1 - Atacar");

        if (jogador is Mago_Terra)
        {
            Console.WriteLine("2 - Magia da Terra");
        }
        else if (jogador is Mago_Agua)
        {
            Console.WriteLine("2 - Magia da Água");
        }
        else if (jogador is Mago)
        {
            Console.WriteLine("2 - Usar Magia");
        }
        else if (jogador is Arqueiro)
        {
            Console.WriteLine("2 - Atirar Flecha");
        }
        else if (jogador is Guerreiro)
        {
            Console.WriteLine("2 - Bloquear");
        }

        string escolhaAcao = Console.ReadLine();

        switch (escolhaAcao)
        {
            case "1":
                jogador.Atacar();
                inimigo.Vida -= 10;
                Console.WriteLine($"{inimigo.Nome} tem {inimigo.Vida} de vida restante.");
                break;
            case "2":
                if (jogador is Mago_Terra magoTerra)
                {
                    magoTerra.Magia_Terra();
                    inimigo.Vida -= 15;
                }
                else if (jogador is Mago_Agua magoAgua)
                {
                    magoAgua.Magia_Agua();
                    inimigo.Vida -= 15;
                }
                else if (jogador is Mago mago)
                {
                    mago.usar_magia();
                    inimigo.Vida -= 12;
                }
                else if (jogador is Arqueiro arqueiro)
                {
                    arqueiro.atirar();
                    inimigo.Vida -= 8;
                }
                else if (jogador is Guerreiro guerreiro)
                {
                    guerreiro.bloquar();
                    Console.WriteLine("Ataque do inimigo bloqueado!");
                }
                Console.WriteLine($"{inimigo.Nome} tem {inimigo.Vida} de vida restante.");
                break;
            default:
                Console.WriteLine("Ação inválida, tente novamente.");
                break;
        }

        if (inimigo.Vida > 0)
        {
            inimigo.Atacar(jogador);
            Console.WriteLine($"{jogador.GetNome} tem {jogador.GetVida} de vida restante.");
        }
    }

    if (jogador.GetVida() <= 0)
    {
        Console.WriteLine("Você perdeu o jogo!");
    }
    else if (inimigo.Vida <= 0)
    {
        Console.WriteLine("Parabéns! Você derrotou o inimigo!");
    }
}
else
{
    Console.WriteLine("Não foi possível iniciar o jogo, personagem inválido.");
}
