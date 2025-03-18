List<string> listaBandas = new List<string> { "Linkin Park", "BFMV", "Metallica" };

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

    Console.WriteLine("Boas vindas ao Screen Sound!");
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para avaliar a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaParseInt = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaParseInt)
    {
        case 1: RegistrarBanda(); break;
        case 2: MostrarBandasRegistradas(); break;
        case 3: Console.WriteLine("Opção escolhida " + opcaoEscolhida); break;
        case 4: Console.WriteLine("Opção escolhida " + opcaoEscolhida); break;

    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("*******************");
    Console.Write("\nDigite o nome da banda: ");

    string nomeBanda = Console.ReadLine()!;
    listaBandas.Add(nomeBanda);

    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Console.WriteLine("\nVoltando ao menu principal...");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*******************");
    Console.WriteLine("Bandas registradas");
    Console.WriteLine("*******************\n");

    foreach(string banda in listaBandas)
    {
        Console.WriteLine($"Banda {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();