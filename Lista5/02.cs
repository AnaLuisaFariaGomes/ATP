int quant;

Console.WriteLine("Insira a quantidade de dígitos que seu número possui: ");
quant = int.Parse(Console.ReadLine());
int[] original = new int[quant];

for (int i = 0; i < original.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}° dígito do número: ");
    original[i] = int.Parse(Console.ReadLine());
}

int[] contrario = new int[quant];
for (int i = 0, j = quant - 1; i < quant; i++, j--)
{
    contrario[i] = original[j];
}

int cont = 0;
for (int i = 0; i < quant; i++)
{
    if (contrario[i] == original[i])
    {
        cont++;
    }
}

if (cont == quant)
{
    Console.WriteLine("O número é palíndromo");
}
else
{
    Console.WriteLine("O número NÃO é palíndromo");
}
