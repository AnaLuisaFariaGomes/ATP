int[] votacao = new int[100];
int nulo = 0, pL = 0, p = 0, m = 0, bE = 0, c = 0;

Console.WriteLine("*** CANDIDATOS  ***");
Console.WriteLine("0 - Perna Longa");
Console.WriteLine("1 - Pluto;");
Console.WriteLine("2 - Mickey;");
Console.WriteLine("3 - Bob Esponja;");
Console.WriteLine("4 - Cebolinha;");

for (int i = 0; i < votacao.Length; i++)
{
    Console.WriteLine($"Digite a opção desejada ({i+1}° voto): ");
    votacao[i] = int.Parse(Console.ReadLine());

    if (votacao[i] == 0)
    {
        pL++;
    }
    else if (votacao[i] == 1)
    {
        p++;
    }
    else if (votacao[i] == 2)
    {
        m++;
    }
    else if (votacao[i] == 3)
    {
        bE++;
    }
    else if (votacao[i] == 4)
    {
        c++;
    }
    else
    {
        nulo++;
    }
}

//continuar aqui
