int num, i, j, fibNum;
string dnv;
bool dnvAns = false;

do
{
    i = 0;
    j = 1;
    fibNum = 0;

    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("        Projeto Fibonacci");
    Console.WriteLine("-----------------------------------\n\n");
    Console.Write("Digite um número inteiro: ");
    num = int.Parse(Console.ReadLine());

    if (num == 0)
    {
        Console.WriteLine("\nO número " + num + " faz parte da sequencia de Fibonacci\n");
    }
    else if (num < 0)
    {
        Console.WriteLine("\nValores negativos não fazem parte da sequencia de Fibonacci\n");
    }
    else
    {
        do
        {
            fibNum = i + j;
            i = j;
            j = fibNum;
        } while (fibNum < num);

        if (num == fibNum)
        {
            Console.WriteLine("\nO número " + num + " faz parte da sequencia de Fibonacci\n");
        }
        else
        {
            Console.WriteLine("\nO número " + num + " não faz parte da sequencia de Fibonacci\n");
        }
    }
    Console.Write("\nDeseja fazer novamente? (s/n): ");

    dnv = Console.ReadLine();

    if (dnv == "s" || dnv == "S")
    {
        dnvAns = true;
    }
    else if (dnv == "n" || dnv == "N")
    {
        dnvAns = false;
    }
    else
    {
        Console.WriteLine("\nValor digitado inválido!\n Finalizando o programa.\n\n");
        dnvAns = false;
    }
} while (dnvAns);