Console.WriteLine("Digite o numero de linhas das matrizes: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o numero de colunas das matrizes: ");
int m = int.Parse(Console.ReadLine());

int[,] mat1 = new int[n, m];
int[,] mat2 = new int[n, m];
Random r = new Random();

for (int i = 0; i < mat1.GetLength(0); i++)
{
    for (int j = 0; j < mat1.GetLength(1); j++)
    {
        mat1[i, j] = r.Next(100);
    }
}

for (int i = 0; i < mat2.GetLength(0); i++)
{
    for (int j = 0; j < mat2.GetLength(1); j++)
    {
        mat2[i, j] = r.Next(100);
    }
}

Console.WriteLine("** MATRIZ 1 **");
for (int i = 0; i < mat1.GetLength(0); i++)
{
    for (int j = 0; j < mat1.GetLength(1); j++)
    {
        Console.Write(mat1[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\n** MATRIZ 2 **");
for (int i = 0; i < mat2.GetLength(0); i++)
{
    for (int j = 0; j < mat2.GetLength(1); j++)
    {
        Console.Write(mat2[i, j] + "\t");
    }
    Console.WriteLine();
}

int cont = 0;
for (int i = 0; i < mat2.GetLength(0); i++)
{
    for (int j = 0; j < mat2.GetLength(1); j++)
    {
        if (mat1[i,j] != mat2[i, j])
        {
            cont++;
        }
    }
}

if (cont > 0)
{
    Console.WriteLine("\nAs matrizes NÃO são iguais");
}
else
{
    Console.WriteLine("\nAs matrizes são iguais");
}
