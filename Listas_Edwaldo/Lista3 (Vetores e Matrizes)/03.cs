static void Main(string[] args)
{
    int[] vet = new int[10];

    for (int i = 0; i < vet.Length; i++)
    {
        Console.WriteLine($"Digite o {i + 1}° num: ");
        vet[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("*** VETOR ORIGINAL ***");
    for (int i = 0; i < vet.Length; i++)
    {
        Console.Write(vet[i] + "\t|");
    }

    int[] vetQuadrado = new int[10];

    for (int i = 0;i < vetQuadrado.Length; i++)
    {
        vetQuadrado[i] = vet[i] * vet[i];
    }

    Console.WriteLine("\n*** VETOR QUADRADO ***");
    for (int i = 0; i < vet.Length; i++)
    {
        Console.Write(vetQuadrado[i] + "\t|");
    }
}
