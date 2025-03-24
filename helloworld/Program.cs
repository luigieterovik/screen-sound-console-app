using System.Linq;

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

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
    Console.WriteLine("Digite 4 para analisar a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaParseInt = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaParseInt)
    {
        case 1: RegistrarBanda(); break;
        case 2: MostrarBandasRegistradas(); break;
        case 3: AvaliarBanda(); break;
        case 4: VerMediaNotaBanda(); break;
        case 5: Console.WriteLine("Opção escolhida " + opcaoEscolhida); break;

    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de bandas");
    Console.Write("\nDigite o nome da banda: ");

    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());

    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Console.WriteLine("\nVoltando ao menu principal...");

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");  
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloOpcao("Bandas registradas");

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda =  Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write("Digite a nota da banda: ");
        string entradaNota = Console.ReadLine()!;

        if (int.TryParse(entradaNota, out int nota))
        {
            bandasRegistradas[nomeBanda].Add(nota);
            Console.WriteLine("Nota cadastrada com sucesso!");
        }
        else
        {
            Console.WriteLine("Valor inválido! Por favor, digite um número válido para a nota.");
        }
    } else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void VerMediaNotaBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Media da banda");
    Console.Write("Digite o nome da banda para ver sua média de nota: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.TryGetValue(nomeBanda, out List<int>? notas))
    {
        if (notas.Count == 0) {
            Console.WriteLine("\nA banda não possui notas");
        }
        else
        {
            double media = notas.Average();
            Console.WriteLine($"\nA média de notas da banda é {media}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

ExibirOpcoesMenu();