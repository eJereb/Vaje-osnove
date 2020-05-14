using System;

namespace požri_ničle
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.Write("Vnesi število: ");
            string st = Console.ReadLine();

            string nova = st.Replace("0", "");
            Console.WriteLine(nova);
        }
    }
}
