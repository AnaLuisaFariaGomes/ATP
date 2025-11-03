static void Main(string[] args)
{
    int[] A = new int[6] { 1, 0, 5, -2, -5, 7};
    int soma = 0;

    for (int i = 0; i < A.Length; i++)
    {
        if (i == 0 || i == 1 || i == 5)
        {
            soma += A[i];
        }else if (i == 3)
        {
            A[i] = 100;
        }
        Console.WriteLine(A[i]);
    }
    Console.WriteLine("soma entre os valores das posições A[0], A[1] e A[5] = " + soma);
}
