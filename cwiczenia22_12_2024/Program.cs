//using System;
//using System.Collections.Generic;

//namespace zad5_1    
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<double> oceny = new List<double>();
//            double liczba, srednia=0;
//            do
//            {
//                Console.WriteLine("Podaj ocene (min. 4). (0 aby zakończyć): ");
//                liczba = double.Parse(Console.ReadLine());

//                if (liczba == 0)
//                    break;
//                else
//                    oceny.Add(liczba);

//            } while (liczba != 0);
//            oceny.Sort();
//            oceny.RemoveAt(0);
//            oceny.RemoveAt(oceny.Count - 1);
//              foreach (double ocena in oceny)

//                srednia += ocena;
//                Console.WriteLine("Średnia: " + (srednia / oceny.Count));


//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//namespace zad5_2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            HashSet<string> imiona = new HashSet<string>();
//            string tekst = "";
//            do
//            {
//                Console.WriteLine("Podaj imie na litere 'A': ");
//                tekst = Console.ReadLine();
//                tekst = tekst.ToUpper();
//                if (tekst == "")
//                    break;
//                else
//                    if (tekst.Substring(0, 1) == "A")
//                    imiona.Add(tekst);
//            } while (true);
//            Console.WriteLine($"unikatowych imion jest {imiona.Count}" + "\n");

//            foreach (string imionaa in imiona)
//                Console.WriteLine(imionaa);

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;

namespace zad5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> kolory = new Stack<string>();
            string kolor;
            int i = 1;
            do
            {
                Console.WriteLine("Podaj kolor zacznij od ulubionego!: ");
                kolor = Console.ReadLine();
                if (kolor == "")
                    break;
                else kolory.Push(kolor);
            } while (true);
            var sortedKolory = kolory.Reverse().OrderByDescending(x => x).ToList();
            foreach (string e in sortedKolory)
            {
                
                Console.WriteLine(i++ + ". " + e);
            }
        }
    }
}
