using System;

namespace pi_monte_carlo
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.Write("Število točk: ");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int znotraj = 0;

            for (int i = 0; i < n; i++)
            {
                

                double x = rnd.NextDouble();
                double y = rnd.NextDouble();
              
                if ((Math.Pow(x,2)+Math.Pow(y, 2)) < 1) //generiramo samo števila med 0 in 1, zato ni absolutnih vrednosti
                {
                    znotraj++;
                }
            }
           
            Console.WriteLine(4 * (double)znotraj / n); // zakaj ne deluje brez double ????

        }
    }
}
