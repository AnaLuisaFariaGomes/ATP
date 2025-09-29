double [] vNotas = new double[200];
double soma = 0;
int op;

for (int i = 0; i < vNotas.Length; i++)
{
    double nota = 0.0;

    Console.WriteLine($"Digite a {i+1}° nota: ");
    nota = double.Parse(Console.ReadLine());
    while (nota < 0 || nota > 100)
    {
        Console.WriteLine("Valor inválido. Insira outro: ");
        nota = double.Parse(Console.ReadLine());
    }
    vNotas[i] = nota;
    soma += nota;
}

Console.WriteLine("*** MENU ***");
Console.WriteLine("1 - Mostrar menor nota;");
Console.WriteLine("2 - Mostrar maior nota;");
Console.WriteLine("3 - Pesquisar nota;");
Console.WriteLine("4 - Mostrar média das notas e quantidade de notas acima da média;");
Console.WriteLine("5 - Sair");
Console.WriteLine("Digite a opção desejada: ");
op = int.Parse(Console.ReadLine());

while (op != 5)
{
    switch (op)
    {
        case 1:
            double menor = 101;
            for (int i = 0; i < vNotas.Length; i++)
            {
                if (vNotas[i] < menor)
                {
                    menor = vNotas[i];
                }
            }
            Console.WriteLine("A menor nota é: "+ menor);
            Console.WriteLine("Digite a opção desejada: ");
            op = int.Parse(Console.ReadLine());
            break;
        case 2:
            double maior = -1;
            for (int i = 0; i < vNotas.Length; i++)
            {
                if (vNotas[i] > maior)
                {
                    maior = vNotas[i];
                }
            }
            Console.WriteLine("A maior nota é: " + maior);
            Console.WriteLine("Digite a opção desejada: ");
            op = int.Parse(Console.ReadLine());
            break;
        case 3:
            Console.WriteLine("Digite a nota que quer pesquisar: ");
            double pesquisa = double.Parse(Console.ReadLine());
            int contP = 0;
            Console.Write("Essa nota aprece nas posições: ");
            for (int i = 0; i < vNotas.Length; i++)
            {
                if (vNotas[i] == pesquisa)
                {
                    Console.Write($"{i}, ");
                    contP++;
                }
            }
            Console.WriteLine($"Totalizando {contP} aparições.");
            Console.WriteLine("Digite a opção desejada: ");
            op = int.Parse(Console.ReadLine());
            break;
        case 4:
            int cont = 0;
            double media = soma / vNotas.Length;
            Console.WriteLine($"Média das notas: {media:F2}");
            for (int i = 0; i < vNotas.Length; i++)
            {
                if (vNotas[i] > media)
                {
                    cont++;
                }
            }
            Console.WriteLine($"Das {vNotas.Length} notas, {cont} estão a cima da média.");
            Console.WriteLine("Digite a opção desejada: ");
            op = int.Parse(Console.ReadLine());
            break;
        case 5:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Digite outra: ");
            op = int.Parse(Console.ReadLine());
            break;
    }
}
