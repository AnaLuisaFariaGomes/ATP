static int Vogais(char[] letras)
{
    int cont = 0;
    for (int i = 0; i < letras.Length; i++)
    {
        if (letras[i] == 'A' || letras[i] == 'E' || letras[i] == 'I' || letras[i] == 'O' || letras[i] == 'U')
        {
            cont++;
        }
    }

    return cont;
}
static void Main(string[] args)
{
    Console.WriteLine("Quantos elementos terão o vetor: ");
    int n = int.Parse(Console.ReadLine());
    char[] letras = new char[n];

    for (int i = 0; i < letras.Length; i++)
    {
        Console.WriteLine($"Digite a {i + 1}° letra do vetor: ");
        letras[i] = char.Parse(Console.ReadLine().ToUpper());
    }

    int totalVogais = Vogais(letras);
    Console.WriteLine($"O total de vogais no vetor é: {totalVogais}");
}
