public static string[,] ConverterCsvParaMatriz(string csv)
{
    string[] linhas = csv.Split('.');
    int totalLinhas = linhas.Length;
    int totalColunas = linhas[0].Split(',').Length;

    string[,] matriz = new string[totalLinhas, totalColunas];

    for (int i = 0; i < totalLinhas; i++)
    {
        string[] colunas = linhas[i].Split(',');
        for (int j = 0; j < totalColunas; j++)
        {
            matriz[i, j] = colunas[j];
        }
    }

    return matriz;
}

static void Main(string[] args)
{
    Console.WriteLine("Digite a string CSV: ");
    string csv = Console.ReadLine();

    string[,] resultado = ConverterCsvParaMatriz(csv);

    for (int i = 0; i < resultado.GetLength(0); i++)
    {
        for (int j = 0; j < resultado.GetLength(1); j++)
        {
            Console.Write($"{resultado[i, j],-10}");
        }
        Console.WriteLine();
    }
}
