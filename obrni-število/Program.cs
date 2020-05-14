using System;

namespace obrni_število
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.Write("Vnesi število: ");
            string st = Console.ReadLine();

            char[] charArray = st.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
