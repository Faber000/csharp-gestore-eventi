public class Evento
{
    private string Titolo;

    private DateTime Data;

    private int CapienzaMassima;
    public int PostiPrenotati { get; set; }

    public Evento(string titolo, DateTime data, int capienzaMassima)
    {
        SetTitolo(titolo);
        SetData(data);
        SetCapienzaMassima(capienzaMassima);
        this.PostiPrenotati = 0;
    }

    public void PrenotaPosti(int posti)
    {
        DateTime thisDay = DateTime.Today;

        if (PostiPrenotati < CapienzaMassima & CapienzaMassima > 0 & DateTime.Compare(thisDay, Data) < 0)
        {
            PostiPrenotati = PostiPrenotati + posti;
        }
        else
        {
            throw new Exception();
        }
    }

    public void DisdiciPosti(int posti)
    {
        DateTime thisDay = DateTime.Today;

        if (posti < PostiPrenotati & DateTime.Compare(thisDay, Data) < 0)
        {
            PostiPrenotati = PostiPrenotati - posti;
        }
        else
        {
            throw new Exception();
        }
    }

    public string ToString()
    {
        string data = Data.ToString("dd/MM/yyyy");

        return "data" + "-" + Titolo;
    }
    public string GetTitolo()
    {
        return Titolo;
    }

    public DateTime GetData()
    {
        return Data;
    }

    public int GetCapienzaMassima()
    {
        return CapienzaMassima;
    }

    public void SetTitolo(string titolo)
    {
        if (titolo != null & titolo != "")
        {
            Titolo = titolo;
        }
        else
        {
            throw new ArgumentNullException();
        }
    }

    public void SetData(DateTime data)
    {
        DateTime thisDay = DateTime.Today;   
        
        if((DateTime.Compare(thisDay, data) < 0)) {
            
            Data = data;
        }
        else
        {
            throw new ArgumentException();
        }
    }

    public void SetCapienzaMassima(int capienza)
    {
        if(capienza > 0)
        {
            CapienzaMassima = capienza;
        }
        else
        {
            throw new ArgumentException();
        }
    }
}

