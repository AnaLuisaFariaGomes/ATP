static double Solucao(int n)
{
    double S = 0;
    for (int i = 1; i <= n; i++)
    {
        S += (Math.Pow(i, 2) + 1) / (i + 3);
    }
    return S;
}
static void Main(string[] args)
{
    Console.WriteLine("Digite o valor de n: ");
    int n = int.Parse(Console.ReadLine());

    double S = Solucao(n);
    Console.WriteLine($"A solução é {S:F2}");
}
