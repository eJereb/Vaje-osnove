using System;

namespace čaramo_s_celimi_števili
{
    class Program
    {
        static void Main ( string[] args )
        {
            Console.Write("Števec: ");
            int stevec = int.Parse(Console.ReadLine());
            Console.Write("Imenovalec: ");
            int imenovalec = int.Parse(Console.ReadLine());
            Console.Write("Število decimalk: ");
            int decimalke = int.Parse(Console.ReadLine());

            int k = 0;
            int ostanek = stevec % imenovalec;
            string rezultat = stevec / imenovalec + "."; //zapišemo celi del pri deljenju in decimalno piko

            while (k <= decimalke-1)
            {
                ostanek = ostanek * 10; //ostanek pomnožimo z 10, da bomo v naslednjem koraku prišli z navadnim deljenjem do decimalk
                int celi_del = ostanek / imenovalec; //dobimo decimalko
                rezultat += celi_del;
                k++;
                ostanek = ostanek % imenovalec; //naslednja decimalka
            }
            Console.WriteLine(rezultat);
        }
    }
}
