static void Main(string[] args)
{
    Console.WriteLine("Digite a 1° palavra: ");
    string palavra1 = Console.ReadLine();
    Console.WriteLine("Digite a 2° palavra: ");
    string palavra2 = Console.ReadLine();

    if (palavra1.Equals(palavra2))
    {
        Console.WriteLine("Strings iguais.");
    }
    else
    {
        if (palavra1.Length > palavra2.Length)
        {
            Console.WriteLine("Palavra mais longa: " + palavra1);
        }
        else
        {
            Console.WriteLine("Palavra mais longa: " + palavra2);
        }
        string resultante = $"{palavra1}  {palavra2}";
        Console.WriteLine("Concatenação das palavras: " + resultante);
    }
}
