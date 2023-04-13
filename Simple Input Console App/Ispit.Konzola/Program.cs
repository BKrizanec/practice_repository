using Ispit.Model;

namespace Ispit.Konzola;

public class Program
{
    static void Main(string[] args)
    {
        bool appRunning = true;
        List<Ucenik> ucenici = new List<Ucenik>();
        Console.WriteLine("Ovo je aplikacija za unos osnovnih podataka učenika.");
        
        while (appRunning)
        {            
            Ucenik ucenik = new Ucenik();

            Console.WriteLine();
            Console.WriteLine("================================================================");
            Console.WriteLine();            

            Console.Write("Molimo unesite ime učenika: ");
            ucenik.Ime = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Molimo unesite prezime učenika: ");
            ucenik.Prezime = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Molimo unesite datum rođenja učenika u formatu mm/dd/yyyy: ");
            if (DateTime.TryParse (Console.ReadLine(), out DateTime datum))
            {
                ucenik.DatumRodjenja = datum;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Unos godišta nije uspješan. Provjerite jeste li unijeli ispravan format (mm/dd/yyyy).");
                continue;
            }

            Console.Write("Molimo unesite prosjek učenika: ");
            if (double.TryParse(Console.ReadLine(), out double prosjek))
            {
                ucenik.Prosjek = prosjek;
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Prosjek nije pravilno izračunat. Molimo da koristite ispravan format. Primjer uspješnog unosa: 4.3.");                
                continue;
            }

            ucenici.Add(ucenik);

            if(ucenici.Count == 3)
            {
                appRunning = false;
            }
        }

        foreach (Ucenik ucenik in ucenici)
        {
            Console.WriteLine();
            Console.WriteLine("Ime i prezime učenika: " + ucenik.Ime + " " + ucenik.Prezime);           
            ucenik.Starost();
            ucenik.IspisProsjeka();
            Console.WriteLine("================================================================");
            Console.WriteLine();
        }
        
        Console.ReadKey();
    }
}