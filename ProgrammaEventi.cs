public class ProgrammaEventi
{
    public string Titolo { get; set; }
    List<Evento> ListaEventi { get; set; } 
    
    public ProgrammaEventi(string titolo)
    {
        Titolo = titolo;
        ListaEventi = new List<Evento>();
    }

    public void AggiungiEvento(Evento evento)
    {
        ListaEventi.Add(evento);
    }

    public List<Evento> EventiPerData(DateTime data)
    {
        List<Evento> ListaPerData = new List<Evento>();
        foreach(Evento evento in ListaEventi)
        {
            if(DateTime.Compare(evento.GetData(), data) == 0)
            {
                ListaPerData.Add(evento);
            }
        }

        return ListaPerData;
    }

    public static void StampaListaEventi(List<Evento> ListaEventi)
    {
        foreach(Evento evento in ListaEventi)
        {
            Console.WriteLine(evento.ToString());
        }
    }

    public int NumeroEventi()
    {
        return ListaEventi.Count;
    }

    public void SvuotaListaEventi()
    {
        ListaEventi.Clear();
    }

    public string ToString()
    {
        string stringa = Titolo + "\n\r";
        foreach(Evento evento in ListaEventi)
        {
            stringa = evento.ToString();
        }
        return stringa;
    }
}
















