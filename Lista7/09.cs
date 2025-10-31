static void ObterMaiorMenor(float[] vet, out float maior, out float menor)
{
    if (vet.Length > 0)
    {
        maior = vet[0];
        menor = vet[0];

        for (int i = 1; i < vet.Length; i++)
        {
            if (vet[i] > maior)
            {
                maior = vet[i];
            }
            if (vet[i] < menor)
            {
                menor = vet[i];
            }
        }
    }
    else
    {
        Console.WriteLine("Valor inválido! O vetor precisa ter elementos");
        maior = 0;
        menor = 0;
    }
}

static void Main(string[] args)
{
    Console.WriteLine("Digite o tamanho do vetor:");
    int n = int.Parse(Console.ReadLine());
    float[] vet = new float[n];
    Random r = new Random();

    Console.WriteLine("*** VETOR ***");
    for (int i = 0; i < vet.Length; i++)
    {
        vet[i] = (float)(r.NextDouble() * 100);
        Console.Write($"{vet[i]:F2}\t|");
    }

    float maior, menor;
    ObterMaiorMenor(vet, out maior, out menor);

    Console.WriteLine($"\n\nMaior valor do vetor: {maior:F2}");
    Console.WriteLine($"Menor valor do vetor: {menor:F2}");
}
