double [] vTemp = new double [31];

for (int i = 0; i < vTemp.Length; i++)
{
    Console.WriteLine($"Digite a temperatura do dia {i+1} de Janeiro:");
    vTemp[i] = double.Parse (Console.ReadLine());
}

Console.WriteLine("Informe a temperatura a pesquisar:");
double temp = double.Parse (Console.ReadLine());

Console.Write("Essa temperatura ocorreu nos seguintes dias: ");
for (int i = 0;i < vTemp.Length;i++)
{
    if (vTemp[i] == temp)
    {
        Console.Write($"{i+1}, ");
    }
}
