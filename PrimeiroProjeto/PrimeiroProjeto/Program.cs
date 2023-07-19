// Screen Sound
string mensagemDeBoasVindas = "Boas Vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{
  Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
}


void ExibirOpcoesDoMenu()
{
  Console.WriteLine("\nDigite 1 para registrar uma banda");
  Console.WriteLine("Digite 2 para mostrar Todas as Bandas");
  Console.WriteLine("Digite 3 Avaliar uma banda");
  Console.WriteLine("Digite 4 Para exibir a media de uma banda");
  Console.WriteLine("Digite -1 para sair");

  Console.Write("\nDigite e sua opção ");
  String OpcaoEscolida = Console.ReadLine()!;
  int OpcaoEscolidaNumerica = int.Parse(OpcaoEscolida);

  switch (OpcaoEscolidaNumerica)
  {
    case 1: Console.WriteLine("você escolheu a opção " + OpcaoEscolidaNumerica);
      break;
    case 2:
      Console.WriteLine("você escolheu a opção " + OpcaoEscolidaNumerica);
      break;
    case 3:
      Console.WriteLine("você escolheu a opção " + OpcaoEscolidaNumerica);
      break;
    case 4:
      Console.WriteLine("você escolheu a opção " + OpcaoEscolidaNumerica);
      break;
    case -1:
      Console.WriteLine("você escolheu a opção"  + OpcaoEscolidaNumerica);
      break;
    default: Console.WriteLine("Num intindi o que você escreveu");
      break;
  }
}

ExibirMensagemDeBoasVindas();
Console.WriteLine(mensagemDeBoasVindas);
ExibirOpcoesDoMenu();