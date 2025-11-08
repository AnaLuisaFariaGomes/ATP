static void Main(string[] args)
{
    Console.WriteLine("Escreva uma palavra: ");
    string palavra = Console.ReadLine().ToUpper();

    for (int i = 0; i < palavra.Length; i++)
    {
        if ('A' == palavra[i] || 'E' == palavra[i] || 'I' == palavra[i] || 'O' == palavra[i] || 'U' == palavra[i])
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(palavra[i]);
        }
    }
}
