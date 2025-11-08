static void ContadorPalavras(string frase)
{
    int cont = 1;

    for (int i = 0; i < frase.Length; i++)
    {
        if (' ' == frase[i])
        {
            cont++;
        }

    }
    Console.WriteLine("Frase: " + frase);
    Console.WriteLine("Número de palavras: " + cont);
}
static void Main(string[] args)
{
    Console.WriteLine("Escreva uma frase: ");
    string frase = Console.ReadLine().ToUpper();
    
    ContadorPalavras(frase);
}
