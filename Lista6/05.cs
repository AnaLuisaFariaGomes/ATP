int[,] mat = new int[500, 500];
Random r = new Random();

for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        mat[i, j] = r.Next(100);
    }
}

Console.WriteLine("** MATRIZ **");
for (int i = 0; i < mat.GetLength(0); i++)
{
    for (int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write(mat[i, j] + "\t");
    }
    Console.WriteLine();
}

//continuar aqui
