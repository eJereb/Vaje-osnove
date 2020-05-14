using System;

namespace bum_
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.Write("Od kod naj štejem? ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Do kod naj štejem? ");
            int b = int.Parse(Console.ReadLine());
            string niz = "";
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    niz += "Bum! ";
                }
                else
                {
                    niz += i + " " ;
                }
            }
            Console.WriteLine(niz);
        }
    }
}
