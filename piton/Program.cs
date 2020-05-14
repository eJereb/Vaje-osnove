using System;


namespace piton
{
    class Program
    {
        static void Main ( string[] args )
        {
            int n, k;
            Console.Write("N:");
            n = int.Parse(Console.ReadLine());
            Console.Write("K:");
            k = int.Parse(Console.ReadLine());

           double vsota = 0;
            for (int i = 0; i < (n+1); i++)
            {
               
                vsota += Math.Pow(i, k);

            }
            Console.WriteLine(vsota);
        }
    }
}
