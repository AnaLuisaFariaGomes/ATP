double[] notas = new double[60];
int count = 0;
double soma = 0;

Console.WriteLine("Digite as notas dos alunos (máximo 60). Digite um valor negativo para encerrar:");

while (count < 60)
{
    Console.Write($"Nota do aluno {count + 1}: ");
    double nota = double.Parse(Console.ReadLine());

    if (nota < 0)
    {
        break;
    }

    notas[count] = nota;
    soma += nota;
    count++;
}

double media = soma / count;

Console.WriteLine("\nNotas de todos os alunos:");
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Aluno {i + 1}: {notas[i]}");
}

Console.WriteLine($"\nNotas acima de ({media:F2}):");
for (int i = 0; i < count; i++)
{
    if (notas[i] > media)
    {
        Console.WriteLine($"Aluno {i + 1}: {notas[i]}");
    }
}
