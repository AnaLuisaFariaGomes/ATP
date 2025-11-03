 static void Main(string[] args)
 {
     int[] vet = new int[6];

     for(int i = 0; i < vet.Length; i++)
     {
         Console.WriteLine($"Digite o {i+1}° num: ");
         vet[i] = int.Parse(Console.ReadLine());
     }

     for(int i = 0;i < vet.Length;i++)
     {
         Console.Write(vet[i] + "\t|");
     }
 }
