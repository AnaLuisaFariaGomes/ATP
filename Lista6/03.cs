int[,] mat = new int[10, 10];
Random r = new Random();

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        mat[i, j] = r.Next(100);
    }
}

Console.WriteLine("** MATRIZ ORIGINAL **");
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write(mat[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i = 0; i < mat.GetLength(1); i++)
{
    for (int j = 0; j < mat.GetLength(0); j++)
    {
        if (i == j)
        {
            mat[i,j] = (int)Math.Sqrt(mat[i, j]);
        }
    }
}

Console.WriteLine("** MATRIZ MODIFICADA **");
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write(mat[i, j] + "\t");
    }
    Console.WriteLine();
}
