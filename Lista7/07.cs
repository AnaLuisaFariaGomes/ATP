 static double Solucao(int n)
 {
     double S = 0;
     for (int i = 1; i <= n; i++)
     {
         S += 1.0 / i;
     }
     return S;
 }
 static void Main(string[] args)
 {
     Console.WriteLine("Digite o valor de n: ");
     int n = int.Parse(Console.ReadLine());

     double S = Solucao(n);
     Console.WriteLine($"A solução é {S:F2}");
 }
