public class Conferenza : Evento
{
    public string Relatore { get; set; }
    public double Prezzo { get; set; }

    public Conferenza(string titolo, DateTime data, int capienzaMassima, string relatore, double prezzo):base(titolo, data, capienzaMassima)
    {
        Relatore = relatore;
        Prezzo = prezzo;
    }

    public string GetPrezzo()
    {
        return Prezzo.ToString("0.00");
    }

    public override string ToString()
    {
        return base.ToString()+" - "+Relatore+" - "+GetPrezzo();
    }
}





















