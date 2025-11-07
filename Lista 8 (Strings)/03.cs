static void Main(string[] args)
{
    Console.WriteLine("Escreva uma palavra: ");
    string palavra = Console.ReadLine().ToUpper();
    int contVogais = 0, contConsoantes = 0;

    for (int i = 0; i < palavra.Length; i++)
    {
        if ('A' == palavra[i] || 'E' == palavra[i] || 'I' == palavra[i] || 'O' == palavra[i] || 'U' == palavra[i])
        {
            contVogais++;
        }
        else
        {
            contConsoantes++;
        }
    }
    Console.WriteLine($"A palavra {palavra} tem {contVogais} vogais e {contConsoantes} consoantes.");
}
