    int n = 500;
    int[,] mat = new int[n, n];
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

    int somaReferencia = 0;
    for (int j = 0; j < n; j++)
    {
        somaReferencia += mat[0, j];
    }

    bool QuadradoMagico = true;

    for (int i = 1; i < n; i++)
    {
        int somaLinha = 0;
        for (int j = 0; j < n; j++)
        {
            somaLinha += mat[i, j];
        }
        if (somaLinha != somaReferencia)
        {
            QuadradoMagico = false;
        }
    }

    for (int j = 0; j < n; j++)
    {
        int somaColuna = 0;
        for (int i = 0; i < n; i++)
        {
            somaColuna += mat[i, j];
        }
        if (somaColuna != somaReferencia)
        {
            QuadradoMagico = false;
        }
    }

    int somaDiagPrincipal = 0;
    for (int i = 0; i < n; i++)
    {
        somaDiagPrincipal += mat[i, i];
    }
    if (somaDiagPrincipal != somaReferencia)
    {
        QuadradoMagico = false;
    }

    int somaDiagSecundaria = 0;
    for (int i = 0; i < n; i++)
    {
        somaDiagSecundaria += mat[i, n - 1 - i];
    }
    if (somaDiagSecundaria != somaReferencia)
    {
        QuadradoMagico = false;
    }

    if (QuadradoMagico)
        Console.WriteLine("A matriz é um quadrado mágico!");
    else
        Console.WriteLine("A matriz NÃO é um quadrado mágico.");
}
