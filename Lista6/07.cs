    char[,] tabuleiro = new char[3, 3];
    int jogadas = 0;
    int linha = 0, coluna = 0;
    bool venceu = false;

    for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
            tabuleiro[i, j] = ' ';

    while (jogadas < 9 && venceu == false)
    {
        char simbolo;
        string jogador;

        if (jogadas % 2 == 0)
        {
            simbolo = 'X';
            jogador = "Jogador 1";
        }
        else
        {
            simbolo = 'O';
            jogador = "Jogador 2";
        }

        Console.WriteLine(jogador + ", informe a linha (0 a 2):");
        linha = int.Parse(Console.ReadLine());
        Console.WriteLine(jogador + ", informe a coluna (0 a 2):");
        coluna = int.Parse(Console.ReadLine());

        while (linha < 0 || linha > 2 || coluna < 0 || coluna > 2 || tabuleiro[linha, coluna] != ' ')
        {
            Console.WriteLine("Jogada inválida. Tente novamente:");
            Console.WriteLine(jogador + ", informe a linha (0 a 2):");
            linha = int.Parse(Console.ReadLine());
            Console.WriteLine(jogador + ", informe a coluna (0 a 2):");
            coluna = int.Parse(Console.ReadLine());
        }

        tabuleiro[linha, coluna] = simbolo;
        jogadas++;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j] + " \t| ");
            }
            Console.WriteLine();
        }

        if ((tabuleiro[0, 0] == simbolo && tabuleiro[0, 1] == simbolo && tabuleiro[0, 2] == simbolo) ||
            (tabuleiro[1, 0] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[1, 2] == simbolo) ||
            (tabuleiro[2, 0] == simbolo && tabuleiro[2, 1] == simbolo && tabuleiro[2, 2] == simbolo) ||
            (tabuleiro[0, 0] == simbolo && tabuleiro[1, 0] == simbolo && tabuleiro[2, 0] == simbolo) ||
            (tabuleiro[0, 1] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 1] == simbolo) ||
            (tabuleiro[0, 2] == simbolo && tabuleiro[1, 2] == simbolo && tabuleiro[2, 2] == simbolo) ||
            (tabuleiro[0, 0] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 2] == simbolo) ||
            (tabuleiro[0, 2] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 0] == simbolo))
        {
            Console.WriteLine(jogador + " venceu!");
            venceu = true;
        }
    }

    if (venceu == false)
    {
        Console.WriteLine("Empate!");
    }
