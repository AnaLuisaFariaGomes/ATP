 internal class _01
 {
     static int Menor(int n1, int n2, int n3, int n4)
     {
         if (n1 =< n2 && n1 =< n3 && n1 =< n4)
         {
             return n1;
         }
         else if (n2 =< n1 && n2 =< n3 && n2 =< n4)
         {
             return n2;
         }
         else if (n3 =< n2 && n3 =< n1 && n3 =< n4)
         {
             return n3;
         }
         else
         {
             return n4;
         }
     }
     static void Main(string[] args)
     {
         Console.WriteLine("Digite o valor de n1: ");
         int n1 = int.Parse(Console.ReadLine());
         Console.WriteLine("Digite o valor de n2: ");
         int n2 = int.Parse(Console.ReadLine());
         Console.WriteLine("Digite o valor de n3: ");
         int n3 = int.Parse(Console.ReadLine());
         Console.WriteLine("Digite o valor de n4: ");
         int n4 = int.Parse(Console.ReadLine());

         int m = Menor(n1, n2, n3, n4);
         Console.WriteLine($"O menor número entre eles é {m}.");
     }
