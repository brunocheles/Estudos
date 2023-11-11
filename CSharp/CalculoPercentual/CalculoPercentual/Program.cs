double[] mediaEstados = new double[5];
string[] estados = new string[] { "SP", "RJ", "MG", "ES", "Outros" };
double soma = 0;
string dnv;
bool esc;
int n;

do
{
    menu();
    Console.WriteLine("\n\nSelecione uma das opções a seguir:");
    Console.WriteLine("1 - Atribuir faturamento mensal básico para teste");
    Console.WriteLine("2 - Atribuir faturamento mensal manualmente");
    Console.WriteLine("9 - Sair");
    Console.Write("\nSua escolha: ");
    n = int.Parse(Console.ReadLine());
    Console.Write("\n");

    switch (n)
    {
        case 1:
            menu();
            soma = 0;
            mediaEstados[0] = 67836.43;
            mediaEstados[1] = 36678.66;
            mediaEstados[2] = 29229.88;
            mediaEstados[3] = 27165.48;
            mediaEstados[4] = 19849.53;
            for(int z = 0; z < 5; z++)
                soma = soma + mediaEstados[z];
            dnv = result(mediaEstados, estados, soma);
            break;
        case 2:
            int i = 0;
            soma = 0;
            do
            {
                menu();
                Console.Write("\nDigite o faturamento do estado de " + estados[i] + ": ");
                mediaEstados[i] = float.Parse(Console.ReadLine());
                soma = soma + mediaEstados[i];
                i++;
            } while (i < 5);
            dnv = result(mediaEstados, estados, soma);
            break;
        case 9:
            Console.WriteLine("Fechando o Programa.");
            dnv = "n";
            break;
        default:
            Console.WriteLine("Opção inválida!\n Fechando o programa.");
            dnv = "n";
            break;
    }

    if (dnv == "s" || dnv == "S")
    {
        esc = true;
    }
    else if (dnv == "n" || dnv == "N")
    {
        esc = false;
    }
    else
    {
        Console.Write("\nValor digitado inválido!\n\nFinalizando o programa.\n\n");
        esc = false;
    }
} while (esc);

static void menu()
{
    Console.Clear();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("        Projeto Percentual Estados");
    Console.WriteLine("------------------------------------------");
}

static string result(double[] mdEsts, string[] ests, double sum)
{
    string y;
    menu();
    Console.WriteLine("\nO faturamento da empresa foi um total de R$" + sum);
    Console.WriteLine("\nEnquanto a porcentagem de representação de cada estado foi:");
    for (int j = 0; j < 5; j++)
    {
        Console.Write(ests[j] + ": " + Math.Round(mdEsts[j] / sum * 100, 2) + "% | valor: R$" + mdEsts[j] + "\n");
    }
    Console.Write("\nDeseja fazer novamente? (s/n): ");
    y = Console.ReadLine();
    return y;
}