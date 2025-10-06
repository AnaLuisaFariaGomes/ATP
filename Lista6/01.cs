Console.WriteLine("Digite o numero de linhas e colunas da matriz: ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n,n];
Random r = new Random();

Console.WriteLine("** Soma das Linhas: **");
for (int i = 0; i < mat.GetLength(0); i++)
{
    int linhas = 0;
    for (int j = 0; j < mat.GetLength(1); j++) {
        mat[i, j] = r.Next(100);
        linhas += mat[i, j];
    }
    Console.WriteLine($"\nLinha {i} = {linhas}");
}

Console.WriteLine("\n** Soma das Colunas: **");
for (int i = 0; i < mat.GetLength(1); i++)
{
    int colunas = 0;
    for (int j = 0; j < mat.GetLength(0); j++)
    {
        colunas += mat[j, i];
    }
    Console.WriteLine($"Coluna {i} = {colunas}");
}

int principal = 0;
Console.Write("\n** Soma da Diagonal Principal: ");
for (int i = 0; i < mat.GetLength(1); i++)
{
    for (int j = 0; j < mat.GetLength(0); j++)
    {
        if (i == j)
        {
            principal += mat[j, i];
        }
    }
}
Console.WriteLine($"{principal} **");

int secundaria = 0;
Console.Write("\n** Soma da Diagonal Secundária: **");
for (int i=0; i < mat.GetLength(0);i++)
{
    secundaria += mat[i, mat.GetLength(1) -1];
}
Console.WriteLine($"{secundaria} **");

Console.WriteLine("\n** MATRIZ **");
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write(mat[i,j] + "\t");
    }
    Console.WriteLine();
}
