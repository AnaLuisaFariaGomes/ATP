static void GerarVetor(ref int[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"Digite o {i+ 1} elemento do vetor: ");
        vetor[i] = int.Parse(Console.ReadLine());
    }
}
static int[] MatriculaSimultanea(int[] vet1, int[] vet2, out int cont)
{
    cont = 0;
    for (int i = 0; i < vet1.Length; i++)
    {
        for (int j = 0; j < vet2.Length; j++)
        {
            if (vet1[i] == vet2[j])
            {
                cont++;
            }
        }
    }

    int[] vetIntersecao = new int[cont];
    int pos = 0;

    for (int i = 0; i < vet1.Length; i++)
    {
        for (int j = 0; j < vet2.Length; j++)
        {
            if (vet1[i] == vet2[j])
            {
                vetIntersecao[pos] = vet1[i];
                pos++;
            }
        }
    }

    return vetIntersecao;
}
static void Main(string[] args)
{
    int n = 10;
    int[] vet1 = new int[n];
    int[] vet2 = new int[n];

    GerarVetor(ref vet1);
    Console.WriteLine("*** VETOR 1 ***");
    for (int i = 0; i < vet1.Length; i++)
    {
        Console.Write($"{vet1[i]}\t|");
    }

    GerarVetor(ref vet2);
    Console.WriteLine("\n*** VETOR 2 ***");
    for (int i = 0; i < vet2.Length; i++)
    {
        Console.Write($"{vet2[i]}\t|");
    }

    int cont;
    int[] vetIntersecao = MatriculaSimultanea(vet1, vet2, out cont);

    if (cont <= 0)
    {
        Console.WriteLine("Não há alunos matriculados simultanamente nas duas diciplinas.");
    }
    else
    {
        Console.WriteLine($"\n{cont} alunos estão matriculados simultanamente nas duas diciplinas.");
    }

    Console.WriteLine("\n*** VETOR INTERSEÇÃO ***");
    for (int i = 0; i < vetIntersecao.Length; i++)
    {
        Console.Write($"{vetIntersecao[i]}\t|");
    }
}
