 static double Ponderada(int n1, int n2, int n3)
 {
     int peso1 = 5, peso2 = 3, peso3 = 2;
     return (n1 * peso1 + n2 * peso2 + n3 * peso3) / (n1 + n2 + n3);
 }
 static void Main(string[] args)
 {
     char letra = 'x';

     int n1, n2, n3;

     while (letra != 'p')
     {
         Console.WriteLine("Digite uma letra: ");
         letra = char.Parse(Console.ReadLine().ToLower());

         if (letra == 'p')

         {
             Console.WriteLine("Digite o 1° número: ");
             n1 = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o 2° número: ");
             n2 = int.Parse(Console.ReadLine());
             Console.WriteLine("Digite o 3° número: ");
             n3 = int.Parse(Console.ReadLine());
             double mediaPonderada = Ponderada(n1, n2, n3);
             Console.WriteLine($"A média ponderada dos números digitados é {mediaPonderada:F2}");
         }
         else
         {
             Console.WriteLine("Letra invélida. Tente novamente: ");
         }
     }
 }
