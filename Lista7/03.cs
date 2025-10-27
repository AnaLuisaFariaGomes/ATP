 static int Mmc(int n1, int n2)
 {
     int maior;

     if (n1 >= n2)
     {
         maior = n1;
     }
     else
     {
         maior = n2;
     }

     int mmc = maior;

     while (mmc % n1 != 0 || mmc % n2 != 0)
     {
         mmc++;
     }

     return mmc;
 }
 static int Mdc(int n1, int n2, int n3)
 {
     int menor, mdc = 1;
     if (n1 <= n2 && n1 <= n3)
     {
         menor = n1;
     }
     else if (n2 <= n1 && n2 <=n3)
     {
         menor = n2;
     }
     else
     {
         menor = n3;
     }

     for (int i = 1; i <= menor; i++)
     {
         if (n1 % i == 0 && n2 % i == 0 && n3 % i ==0)
         {
             mdc = i;
         }
     }
     return mdc;
 }
 static void Main(string[] args)
 {
     int op;

     Console.WriteLine("*** MENU ***");
     Console.WriteLine("1 - Calcular MMC");
     Console.WriteLine("2 - Calcular MDC");
     Console.WriteLine("3 - Sair");
     Console.WriteLine("Digite a opição desejada: ");
     op = int.Parse(Console.ReadLine());

     while (op != 3)
     {
         Console.Clear();
         switch (op)
         {
             case 1:
                 Console.WriteLine("Digite n1: ");
                 int n1 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Digite n2: ");
                 int n2 = int.Parse(Console.ReadLine());

                 int mmc = Mmc(n1, n2);
                 Console.WriteLine("O MMC entre esses números é "+ mmc);
                 break;
             case 2:
                 Console.WriteLine("Digite n1: ");
                 int num1 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Digite n2: ");
                 int num2 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Digite n3: ");
                 int num3 = int.Parse(Console.ReadLine());

                 int mdc = Mdc(num1, num2, num3);
                 Console.WriteLine("O MDC entre esses números é " + mdc);
                 break;
             case 3:
                 break;
             default:
                 Console.WriteLine("Opção inválida tente novamente.");
                 break;
         }

         Console.WriteLine("*** MENU ***");
         Console.WriteLine("1 - Calcular MMC");
         Console.WriteLine("2 - Calcular MDC");
         Console.WriteLine("3 - Sair");
         Console.WriteLine("Digite a opição desejada: ");
         op = int.Parse(Console.ReadLine());
     }
 }
