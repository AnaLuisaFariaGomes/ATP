 double[,] mat = new double[3, 6];
 Random r = new Random();

 for (int i = 0; i < mat.GetLength(0); i++)
 {
     for (int j = 0; j < mat.GetLength(1); j++)
     {
         mat[i, j] = r.NextDouble();
     }
 }

 Console.WriteLine("** MATRIZ **");
 for (int i = 0; i < mat.GetLength(0); i++)
 {
     for (int j = 0; j < mat.GetLength(1); j++)
     {
         Console.Write(mat[i, j] + "\t");
     }
     Console.WriteLine();
 }

 double impares = 0;
 int cont = 0;
 Console.WriteLine("\n** Soma das Colunas Pares: **");
 for (int i = 0; i < mat.GetLength(1); i++)
 {
     double soma = 0;
     for (int j = 0; j < mat.GetLength(0); j++)
     {
             soma += mat[j, i];
     }
     if (i % 2 == 0)
     {
         Console.WriteLine($"Coluna {i} = {soma}");
     }
     if (i == 3 || i == 5)
     {
         impares += soma;
         cont++;
     }
 }

 Console.WriteLine("\nA média aritmética dos elementos das colunas 3 e 5 é: " + impares/cont);

 Console.WriteLine("** MATRIZ MODIFICADA **");
 for (int i = 0; i < mat.GetLength(0); i++)
 {
     double soma = 0;
     for (int j = 0; j < mat.GetLength(1); j++)
     {
         if (j == 1 || j == 2)
         {
             soma += mat[i, j];
         }
         if (j == 5)
         {
             mat[i, j] = soma;
         }
         Console.Write(mat[i,j] + "\t");
     }
     Console.WriteLine();
 }
