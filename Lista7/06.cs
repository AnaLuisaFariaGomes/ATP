static int[,] MultiplicarEscalar(int[,] matriz, int n)
{
    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);

    int[,] mat2 = new int[linhas, colunas];

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < colunas; j++)
        {
            mat2[i, j] = matriz[i, j] * n;
        }
    }

    return mat2;
}
static void Main(string[] args)
{
    int[,] mat = new int[3, 3];
    Random r = new Random();

    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = r.Next(10);
            Console.Write(mat[i, j] + " \t| ");
        }
        Console.WriteLine("");
    }

    Console.WriteLine("Digite um número para multiplicar a matriz: ");
    int n = int.Parse(Console.ReadLine());

    int[,] mat2 = MultiplicarEscalar(mat, n);
    Console.WriteLine("Matriz resultante: ");
    for (int i = 0; i < mat2.GetLength(0); i++)
    {
        for (int j = 0; j < mat2.GetLength(1); j++)
        {
            Console.Write(mat2[i, j] + " \t| ");
        }
        Console.WriteLine("");
    }
}
