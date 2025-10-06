int[] vetA = new int[10];
int[] vetB = new int[10];
char[] vetC = new char[10];
double[] vetD = new double[10];

Console.WriteLine("Digite os valores para VetA:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"VetA[{i}]: ");
    vetA[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite os valores para VetB:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"VetB[{i}]: ");
    vetB[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite as operações (+, -, *, /) para VetC:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"VetC[{i}]: ");
    vetC[i] = char.Parse(Console.ReadLine());
}

for (int i = 0; i < 10; i++)
{
    switch (vetC[i])
    {
        case '+': 
            vetD[i] = vetA[i] + vetB[i]; 
            break;
        case '-': 
            vetD[i] = vetA[i] - vetB[i]; 
            break;
        case '*': 
            vetD[i] = vetA[i] * vetB[i]; 
            break;
        case '/':
            vetD[i] = vetB[i] != 0 ? (double)vetA[i] / vetB[i] : 0;
            break;
        default: 
            vetD[i] = 0; 
            break;
    }
}

Console.WriteLine("\nResultado VetD:");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"VetD[{i}] = {vetD[i]}");
}
