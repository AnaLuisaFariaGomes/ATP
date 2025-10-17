const int n = 4;
int[,] mat = new int[n, n];
Random r = new Random();
bool triangular = true;

Console.WriteLine("** MATRIZ **\n");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        mat[i, j] = r.Next(0, 100);
        Console.Write($"{mat[i, j],4}");
    }
    Console.WriteLine();
}

for (int i = 1; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (mat[i, j] != 0) { 
            triangular = false;
        }
    }
}

if (triangular) { 
    Console.WriteLine("\nA matriz é triangular superior.");
}
else { 
    Console.WriteLine("\nA matriz não é triangular superior.");
}
