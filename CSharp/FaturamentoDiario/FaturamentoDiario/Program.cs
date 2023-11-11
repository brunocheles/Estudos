List<int> feriadosRibeirao = new List<int> { 20, 51, 52, 53, 97, 111, 121, 159, 170, 250, 285, 306, 319, 359 };
int n, valorMenor = 10000, diaMenor = 1, valorMaior = 1, diaMaior = 1, k = 0, diasMaiores = 0;
double media = 0;
bool esc = false;
int[] dias = new int[366];
int[] diasMais = new int[260];
string dnv;
Random rnd = new Random();

dias[0] = 0;
int j = 1;

for (int i = 1; i <= 365; i++)
{
    if (j < 6 && !IsFeriado(i, feriadosRibeirao))
    {
        dias[i] = rnd.Next(1000, 10000);
        diasMais[k] = dias[i];
        if (dias[i] < valorMenor)
        {
            valorMenor = dias[i];
            diaMenor = i;
        }
        else if (dias[i] > valorMaior)
        {
            valorMaior = dias[i];
            diaMaior = i;
        }
        media = media + dias[i];
        k++;
    }
    else
    {
        dias[i] = 0;
        if (j == 7)
        {
            j = 1;
        }
    }
    i++;
    j++;
}
media = Math.Round(media / k, 2);
for (int i = 0; i < k; i++)
{
    if (diasMais[i] > media)
    {
        diasMaiores++;
    }
}

do
{
    Console.Clear();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("   Projeto faturamento diário - 2023");
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("\n\nSelecione uma das opções a seguir:");
    Console.WriteLine("1 - O dia com o menor valor de faturamento");
    Console.WriteLine("2 - O dia com o maior valor de faturamento");
    Console.WriteLine("3 - Média anual de faturamento");
    Console.WriteLine("4 - Número de dias no ano em que o valor de faturamento foi superior que à média anual");
    Console.WriteLine("5 - Ver os valores dos feriados");
    Console.WriteLine("9 - Sair");
    Console.Write("\nSua escolha: ");
    n = int.Parse(Console.ReadLine());
    Console.Write("\n");

    switch(n)
    {
        case 1: 
            Console.WriteLine("O dia do ano com o menor valor é o dia " + diaMenor + " com o valor de R$" + valorMenor);
            break;
        case 2:
            Console.WriteLine("O dia do ano com o menor valor é o dia " + diaMaior + " com o valor de R$" + valorMaior);
            break;
        case 3:
            Console.WriteLine("A média de faturamento do ano de 2023 foi de R$" + media);
            break;
        case 4:
            Console.WriteLine("No ano, foram um total de " + diasMaiores + " dias com faturamento acima da média!");
            break;
        case 5:
            int l = 0;
            foreach(int dia in feriadosRibeirao)
            {
                Console.WriteLine("Feriado do dia " + feriadosRibeirao[l] + " teve um faturamento de R$" + dias[dia]);
                l++;
            }
            break;
        case 9:
            Console.WriteLine("Fechando o Programa.");
            break;
        default:
            Console.WriteLine("Opção inválida!\nFechando o programa.");
            break;
    }

    if (n <= 5 && n > 0)
    {
        Console.Write("\nDeseja fazer novamente? (s/n): ");
        dnv = Console.ReadLine();
    }
    else
    {
        dnv = "n";
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
        Console.WriteLine("\nValor digitado inválido!\n Finalizando o programa.\n\n");
        esc = false;
    }
} while (esc);

static bool IsFeriado(int dia, List<int> listaFeriados)
{
    if (listaFeriados.Contains(dia))
    {
        return true;
    }
    else
    {
        return false;
    }
}