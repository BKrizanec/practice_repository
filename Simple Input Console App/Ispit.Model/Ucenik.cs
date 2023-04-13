namespace Ispit.Model;

public class Ucenik
{
    public string Ime { get; set; }
    public string Prezime { get; set;}
    public DateTime DatumRodjenja { get; set; }
    public double Prosjek { get; set; }

    
    public void Starost()
    {
        DateTime danas = DateTime.Today;            
        int starost = danas.Year - DatumRodjenja.Year;

        if (danas.Year > DatumRodjenja.Year)
        {
            Console.WriteLine("Godište učenika: " + DatumRodjenja.Year + ".");
            Console.WriteLine("Starost učenika u godinama: " + starost + "."); 
        }
        else
        {
            Console.WriteLine("Unos godišta nije bio uspješan. Provjerite jeste li unijeli ispravan format (mm/dd/yyyy).");
        }
    }

    public void IspisProsjeka()
    {
        if (Prosjek >= 1 && Prosjek <= 1.49)
        {
            Console.WriteLine("Prosjek učenika je: " + Prosjek + ". Uspjeh učenika je nedovoljan.");
        }
        else if (Prosjek >= 1.50 && Prosjek <= 2.49)
        {
            Console.WriteLine("Prosjek učenika je: " + Prosjek + ". Uspjeh učenika je dovoljan.");
        }
        else if (Prosjek >= 2.50 && Prosjek <= 3.49)
        {
            Console.WriteLine("Prosjek učenika je: " + Prosjek + ". Uspjeh učenika je dobar.");
        }
        else if (Prosjek >= 3.50 && Prosjek <= 4.49)
        {
            Console.WriteLine("Prosjek učenika je: " + Prosjek + ". Uspjeh učenika je vrlo dobar.");
        }
        else if (Prosjek >= 4.50 && Prosjek <= 5.00)
        {
            Console.WriteLine("Prosjek učenika je: " + Prosjek + ". Uspjeh učenika je odličan.");
        }
        else
        {
            Console.WriteLine("Prosjek nije pravilno izračunat. Molimo da koristite ispravan format. Primjer uspješnog unosa: 4.3.");                
        }
    }
}
