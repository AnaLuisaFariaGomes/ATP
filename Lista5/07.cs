int[] x = new int[5];
int[] y = new int[5];

Console.WriteLine("Digite os valores para o vetor X:");
for (int i = 0; i < 5; i++)
{
    x[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite os valores para o vetor Y:");
for (int i = 0; i < 5; i++)
{
    y[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nDiferença entre X e Y:");
for (int i = 0; i < 5; i++)
{
    bool existe = false;
    for (int j = 0; j < 5; j++)
    {
        if (x[i] == y[j])
        {
            existe = true;
            break;
        }
    }
    if (!existe)
        Console.WriteLine(x[i]);
}

Console.WriteLine("\nInterseção entre X e Y:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (x[i] == y[j])
        {
            Console.WriteLine(x[i]);
            break;
        }
    }
}

Console.WriteLine("\nUnião entre X e Y:");
int[] uniao = new int[10];
int tamanho = 0;

for (int i = 0; i < 5; i++)
{
    bool existe = false;
    for (int j = 0; j < tamanho; j++)
    {
        if (x[i] == uniao[j])
        {
            existe = true;
            break;
        }
    }
    if (!existe)
    {
        uniao[tamanho] = x[i];
        tamanho++;
    }
}

for (int i = 0; i < 5; i++)
{
    bool existe = false;
    for (int j = 0; j < tamanho; j++)
    {
        if (y[i] == uniao[j])
        {
            existe = true;
            break;
        }
    }
    if (!existe)
    {
        uniao[tamanho] = y[i];
        tamanho++;
    }
}

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine(uniao[i]);
}
