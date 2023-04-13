namespace Ispit.Konzola;

public class Program
{      
    static void Main(string[] args)
    {
        PametniTelefon.PostavkeTelefona();
        PametniTelefon pametniTelefon = new PametniTelefon("Microsoft Lumia 950 XL");

        #region Roleplay
        Console.WriteLine("Ovo je aplikacija za provjeru telefonskih brojeva i url-a. ");
        Thread.Sleep(2000);
        Console.WriteLine($"Učitavam postavke na hrvatskom jeziku za {pametniTelefon.Model}. Molimo pričekajte. ");
        Thread.Sleep(2000);
        Console.WriteLine("...");
        Thread.Sleep(2000);
        Console.WriteLine("Učitavanje gotovo. Možete početi sa testom.");        
        Thread.Sleep(2000);
        Console.WriteLine();
        Console.WriteLine("=====================================================================================");
        Console.WriteLine();
        #endregion

        TestirajTelefon(pametniTelefon);
        
        Console.ReadKey();
    }
       

    #region Methods
    public static void TestirajTelefon(PametniTelefon telefon)
   {
        bool testTelefona = true;

        while (testTelefona) 
        {
            Console.WriteLine("================| PROVJERA BROJA |================");
            Console.Write("Unesite telefonski broj: ");
            string telefonski_broj = Console.ReadLine();

            if(String.IsNullOrEmpty(telefonski_broj))
            {
                Console.WriteLine("Molimo da unesete ispravnu vrijednost. ");
                Console.WriteLine();
                continue;
            }
            else
            {
                if(telefon.ProvjeriAkoJeValidanBroj(telefonski_broj))
                {
                    telefon.Poziv(telefonski_broj);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine();
            Console.WriteLine("===============| PROVJERA STRANICE |===============");
            Console.Write("Unesite web stranicu koju želite posjetiti: ");
            string urlEntry = Console.ReadLine();
            
            if(String.IsNullOrEmpty(urlEntry))
            {
                Console.WriteLine("Molimo da unesete ispravnu vrijednost. ");
                Console.WriteLine();
                continue;
            }
            else
            {
                if(telefon.ProvjeriAkoJeValidanUrl(urlEntry))
                {
                    telefon.Surfanje(urlEntry);
                    testTelefona = false;
                }
                else
                {
                    continue;
                }                
            }            
        }    
   }

    #endregion
}