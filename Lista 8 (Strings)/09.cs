static string GerarEmail(string nome)
{
    string[] partes = nome.ToLower().Split(' ');
    string primeiroNome = partes[0];
    string ultimoSobrenome = partes[partes.Length - 1];

    string email = $"{primeiroNome}.{ultimoSobrenome}@acme.br";
    return email;
}
static void Main(string[] args)
{
    Console.WriteLine("Digite o nome completo: ");
    string nome = Console.ReadLine().ToLower();
    string email = GerarEmail(nome);
    Console.WriteLine(email);
}
