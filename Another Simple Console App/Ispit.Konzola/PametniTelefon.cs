using Ispit.Konzola.Sucelja;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Ispit.Konzola;

public class PametniTelefon : IPametniTelefon, ITelefon
{
    public string Model { get; private set; }

    public PametniTelefon(string model) 
    {
        Model = model;
    }

    #region Postavke
    public static void PostavkeTelefona()
    {
        Console.OutputEncoding = Encoding.UTF8;
        CultureInfo ci = new CultureInfo("hr-HR");
        Thread.CurrentThread.CurrentCulture = ci;
    }
    #endregion

    #region Glavne validacijske metode
    public string Surfanje(string url)
    {     
        Regex validirajUrl = new Regex("^(http:\\/\\/www\\.|https:\\/\\/www\\.|http:\\/\\/|https:\\/\\/)?[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$");

        if(validirajUrl.IsMatch(url)) 
        {
            Console.WriteLine($"Moguće je surfati na {url}!");
            Console.WriteLine();
            return url;
        }
        else
        {
            Console.WriteLine("Nije moguće pristupiti ovoj stranici. ");
            Console.WriteLine();
            return string.Empty;
        }        
    }
    public string Poziv(string telefonski_broj)
    {
        Regex validirajBroj = new Regex("^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
        
        if(validirajBroj.IsMatch(telefonski_broj))
        {
            Console.WriteLine($"Moguće je zvati broj: {telefonski_broj}");
            Console.WriteLine();
            return telefonski_broj;

        }
        else
        {
            Console.WriteLine("Nije moguće zvati ovaj broj.");
            Console.WriteLine();
            return string.Empty;
        }
    }
    #endregion

    #region Metode za provjeru brojeva u stringovima
    public bool ProvjeriAkoJeValidanUrl(string url) 
    {
        if (url.Any(c => char.IsDigit(c)))
        {
            Console.WriteLine("Vaš unos je neispravan. ");
            Console.WriteLine();
            return false;
        }
        else
        {            
            return true;
        }        
    }
    public bool ProvjeriAkoJeValidanBroj(string telefonski_broj) 
    {        
        if(telefonski_broj.All(c => char.IsDigit(c)))
        {              
            return true; 
        }
        else
        {
            Console.WriteLine("Vaš unos je neispravan. ");
            Console.WriteLine();
            return false;
        }
    }
    #endregion
}
