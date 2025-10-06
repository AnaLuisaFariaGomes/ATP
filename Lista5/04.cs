int[] votacao = new int[100];
int[] votos = new int[5];
int nulo = 0;

Console.WriteLine("*** CANDIDATOS  ***");
Console.WriteLine("0 - Perna Longa");
Console.WriteLine("1 - Pluto;");
Console.WriteLine("2 - Mickey;");
Console.WriteLine("3 - Bob Esponja;");
Console.WriteLine("4 - Cebolinha;");

for (int i = 0; i < votacao.Length; i++)
{
    Console.WriteLine($"Digite a opção desejada ({i + 1}° voto): ");
    votacao[i] = int.Parse(Console.ReadLine());

    if (votacao[i] >= 0 && votacao[i] < votos.Length)
    {
        votos[votacao[i]]++;
    }
    else
    {
        nulo++;
    }

}

int mais = 0;
int menos = 0;

for (int i = 1; i < votos.Length; i++)
{
    if (votos[i] > votos[mais])
    {
        mais = i;
    }
    if (votos[i] < votos[menos])
    {
        menos = i;
    }
}

Console.WriteLine($"O candidato mais votado foi: {mais} com {votos[mais]} votos.");

switch (menos)
{
    case 0:
        Console.WriteLine($"O candidato menos votado foi: Perna Longa com {votos[menos]} votos.");
        break;
    case 1:
        Console.WriteLine($"O candidato menos votado foi: Pluto com {votos[menos]} votos.");
        break;
    case 2:
        Console.WriteLine($"O candidato menos votado foi: Mickey com {votos[menos]} votos.");
        break;
    case 3:
        Console.WriteLine($"O candidato menos votado foi: Bob Esponja com {votos[menos]} votos.");
        break;
    case 4:
        Console.WriteLine($"O candidato menos votado foi: Cebolinha com {votos[menos]} votos.");
        break;
    default:
        Console.WriteLine("Não há candidato menos votado");
        break;
}
Console.WriteLine($"Houveram {nulo} votos nulos.");
