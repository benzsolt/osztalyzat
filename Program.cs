using System;

namespace osztalyzat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg az elért pontszámot: ");
            int pontSzam = int.Parse(Console.ReadLine());

            if (pontSzam < 0 || pontSzam > 100)
            {
                Console.WriteLine("A bevitt adat hibás!");
            }
            else if (pontSzam > 0 && pontSzam <= 50)
            {
                Console.WriteLine("Elégtelen");
            }
            else if (pontSzam > 50 && pontSzam <= 65)
            {
                Console.WriteLine("Elégséges");
            }
            else if (pontSzam > 65 && pontSzam <= 80)
            {
                Console.WriteLine("Közepes");
            }
            else if (pontSzam > 80 && pontSzam <= 90)
            {
                Console.WriteLine("Jó");
            }
            else
            {
                Console.WriteLine("Jeles");
            }
            Console.ReadKey();
        }
    }
}
