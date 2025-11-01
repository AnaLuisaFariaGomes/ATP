static void ConverterSegundos(int totalSegundos, out int hora, out int min, out int seg)
{
    hora = totalSegundos / 3600;
    int resto = totalSegundos % 3600;
    min = resto / 60;
    seg = resto % 60;
}
static void Main(string[] args)
{
    int hora, min, seg;

    Console.WriteLine("Digite a quantidade de segundos: ");
    int totalSegundos = int.Parse(Console.ReadLine());

    ConverterSegundos(totalSegundos, out hora, out min, out seg);
    Console.WriteLine($"{totalSegundos} segundos equivalem á {hora}h:{min}min:{seg}s");

}
