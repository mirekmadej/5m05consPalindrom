using System.Reflection.Metadata;

namespace _5m05consPalindrom
{
    internal class Program
    {
        private static bool czyPalindrom(string slowo)
        {
            slowo = slowo.ToLower();
            string w = "";
            foreach (var c in slowo)
                w = c + w;
            return w == slowo;
        }
        private static bool czyPalindrom2(string slowo)
        {
            slowo = slowo.ToLower();
            for (int i = 0; i < slowo.Length / 2; i++)
                if (slowo[i] != slowo[slowo.Length - 1 - i])
                    return false;
            return true;
        }
        private static bool czyPalindrom(int n)
        {
            return czyPalindrom(n.ToString());
        }
        private static bool czyPalindrom3(string slowo)
        {
            string s = " .,?!";
            string w = "";
            foreach (var c in slowo)
                if (s.IndexOf(c) == -1)
                    w += c;
            return czyPalindrom(w);
        }
        static void Main(string[] args)
        {
            Console.Write("poaj słowo: ");
            //string slowo = Console.ReadLine();  
            string slowo = "kajak";
            if (czyPalindrom2(slowo))
                Console.WriteLine($"{slowo} to jest palindrom");
            else
                Console.WriteLine($"{slowo} to nie jest palindrom");
            
            
            Console.WriteLine("Podaj liczbę");
            //int liczba = int.Parse(Console.ReadLine());
            int liczba = 34234234;
            if (czyPalindrom(liczba))
                Console.WriteLine($"{liczba} to jest palindrom");
            else
                Console.WriteLine($"{liczba} to nie jest palindrom");
            
            slowo = "Zakopane na pokaz.";
            if (czyPalindrom3(slowo))
                Console.WriteLine($"{slowo} to jest palindrom");
            else
                Console.WriteLine($"{slowo} to nie jest palindrom");
            

    }
}
