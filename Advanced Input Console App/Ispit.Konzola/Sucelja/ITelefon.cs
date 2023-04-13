namespace Ispit.Konzola.Sucelja;

public interface ITelefon
{
    string Model { get; }
    string Poziv(string telefonski_broj);    
}
