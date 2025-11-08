 static void Main(string[] args)
 {
     Console.WriteLine("Escreva uma palavra: ");
     string palavra = Console.ReadLine().ToUpper();
     bool verbo = palavra.EndsWith("AR");

     while (verbo == false)
     {
         Console.WriteLine("A palavra digitada não é um verbo terminado em 'AR'. Por favor, tente novamente.");
         Console.WriteLine("Escreva uma palavra: ");
         palavra = Console.ReadLine().ToUpper();
         verbo = palavra.EndsWith("AR");
     }

         string radical = palavra.Substring(0, palavra.Length - 2);

         Console.WriteLine("\n*** Presente ***");
         Console.WriteLine($"{radical}O");
         Console.WriteLine($"{radical}AS");
         Console.WriteLine($"{radical}A");
         Console.WriteLine($"{radical}AMOS");
         Console.WriteLine($"{radical}AIS");
         Console.WriteLine($"{radical}AM");

         Console.WriteLine("\n*** Pretérito Perfeito ***");
         Console.WriteLine($"{radical}EI");
         Console.WriteLine($"{radical}ASTE");
         Console.WriteLine($"{radical}OU");
         Console.WriteLine($"{radical}AMOS");
         Console.WriteLine($"{radical}ASTES");
         Console.WriteLine($"{radical}ARAM");

         Console.WriteLine("\n*** Futuro do Presente ***");
         Console.WriteLine($"{verbo}EI");
         Console.WriteLine($"{verbo}ÁS");
         Console.WriteLine($"{verbo}Á");
         Console.WriteLine($"{verbo}EMOS");
         Console.WriteLine($"{verbo}EIS");
         Console.WriteLine($"{verbo}ÃO");
 }
