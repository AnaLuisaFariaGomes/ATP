static void RetornaMaior(int[,] matriz, ref int k, ref int lin, ref int col)
{
    int maior = matriz[0, 0];
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
           if (matriz[i, j] > maior)
            {
                maior = matriz[i, j];
                lin = i;
                col = j;
            }
        }
    }
}
static void Main(string[] args)
{
    Console.WriteLine("Digite o tamanho da matriz: ");
    int tam = int.Parse(Console.ReadLine());
    int[,] mat = new int[tam, tam];
    Random r = new Random();

    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = r.Next(100);
            Console.Write(mat[i, j] + " \t| ");
        }
        Console.WriteLine("");
    }

    int k = 0, lin = -1, col = -1;
    RetornaMaior(mat, ref k, ref lin, ref col);
    Console.WriteLine($"O maior valor é {k}, que está na linha {lin} e coluna {col}.");
}
