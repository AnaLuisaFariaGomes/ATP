 static double Hipotenusa(double a, double b)
 {
     return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
 }
 static void Main(string[] args)
 {
     Console.WriteLine("Digite o valor do cateto a: ");
     double a = double.Parse(Console.ReadLine());
     Console.WriteLine("Digite o valor do cateto b: ");
     double b = double.Parse(Console.ReadLine());

     double hip = Hipotenusa(a, b);
     Console.WriteLine($"A hipotenusa desse triÂngulo é: {hip}");
 }
