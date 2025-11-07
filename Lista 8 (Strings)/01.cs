static void Main(string[] args)
{
    Console.WriteLine("Escreva uma palavra: ");
    string palavra = Console.ReadLine().ToUpper();
    Console.WriteLine("Digite uma letra: ");
    char letra = char.Parse(Console.ReadLine().ToUpper());
    int cont = 0;

    for (int i = 0; i < palavra.Length; i++)
    {
        if (letra == palavra[i])
        {
            cont++;
        }
    }
    Console.WriteLine($"A letra {letra} está presente {cont} vezes na palavra {palavra}.");
}
