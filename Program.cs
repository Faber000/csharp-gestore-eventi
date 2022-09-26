using System;

string risposta;
string nomeEvento, dataStringa;
DateTime dataFormattata;
int capienzaMassima;

// Menu 
Console.WriteLine("Inserisci 1 per creare un singolo evento");
Console.WriteLine("Inserisci 2 per creare un programma di eventi");
risposta = Console.ReadLine();

switch (risposta)
{
    case "1":
        try
        {
            CreaEvento();
        }
        catch(Exception)
        {
            Console.WriteLine("si è verificato un errore");
        }
        break;

    case "2":
        CreaProgrammaEventi();
        break;

    default:
        break;
}

void CreaEvento()
{
    // Ottengo il nome del nuovo evento
    Console.WriteLine("Inserisci il titolo del nuovo evento");
    nomeEvento = Console.ReadLine();

    // Ottengo la data dell'evento
    Console.WriteLine("Inserisci la data dell'evento");
    dataStringa = Console.ReadLine();
    dataFormattata = Convert.ToDateTime(dataStringa);

    // Ottengo la capienza massima dell'evento
    Console.WriteLine("Inserisci la capienza massima");
    capienzaMassima = Convert.ToInt32(Console.ReadLine());

    // Istanzio il nuovo evento
    Evento evento = new Evento(nomeEvento, dataFormattata, capienzaMassima);

    // Ottengo il numero di prenotazioni
    Console.WriteLine("Quante prenotazioni vuoi effettuare?");
    int numeroPrenotazioni = Convert.ToInt32(Console.ReadLine());

    // Effettuo la prenotazione
    evento.PrenotaPosti(numeroPrenotazioni);

    Console.WriteLine("sono stati prenotati " + evento.PostiPrenotati + " posti");

    Console.WriteLine("vuoi disdire dei posti? (si/no)");
    risposta = Console.ReadLine();

    while (risposta == "si")
    {
        // Ottengo il numero di posti da disdire
        Console.WriteLine("quanti posti vuoi disdire?");
        int postiDisdetti = Convert.ToInt32(Console.ReadLine());

        // Disdico i posti
        evento.DisdiciPosti(postiDisdetti);

        Console.WriteLine("sono stati prenotati " + evento.PostiPrenotati + " posti");

        Console.WriteLine("i posti disponibili sono: " + evento.GetPostiDisponibili());

        Console.WriteLine("vuoi disdire dei posti? (si/no)");

        risposta = Console.ReadLine();
    }
}

void CreaProgrammaEventi()
{
    // Ottengo il nome del programma eventi
    Console.WriteLine("Inserisci il nome del tuo programma eventi");
    string nomeProgramma = Console.ReadLine();

    // Istanzio il nuovo programma
    ProgrammaEventi programmaEventi = new ProgrammaEventi(nomeProgramma);

    // Ottengo il numero degli eventi
    Console.WriteLine("Quanti eventi vuoi inserire?");
    int numeroEventi = Convert.ToInt32(Console.ReadLine());

    // Ciclo per ogni evento
    for (int i = 0; i < numeroEventi; i++)
    {
        // Ottengo il nome del singolo evento
        Console.WriteLine("Inserisci il nome del " + (i + 1) + "° evento: ");
        nomeEvento = Console.ReadLine();

        // Ottengo la data del singolo evento
        Console.WriteLine("Inserisci la data dell'evento (dd/MM/yyyy)");
        dataStringa = Console.ReadLine();
        dataFormattata = Convert.ToDateTime(dataStringa);

        // Ottengo la capienza del singolo evento
        Console.WriteLine("Inserisci il numero di posti totali");
        capienzaMassima = Convert.ToInt32(Console.ReadLine());

        try
        {
            // Istanzio il nuovo evento
            Evento nuovoEvento = new Evento(nomeEvento, dataFormattata, capienzaMassima);

            // Aggiungo l'evento al programma
            programmaEventi.AggiungiEvento(nuovoEvento);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Argomento nullo");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Argomento non valido");
        }
        catch (Exception)
        {
            Console.WriteLine("Si è verificato un errore");
        }
    }

    // Ottengo il nome della conferenza
    Console.WriteLine("Inserisci il nome della conferenza");
    string nomeConferenza = Console.ReadLine();

    // Ottengo la data della conferenza
    Console.WriteLine("Inserisci la data della conferenza(dd/MM/yyyy)");
    dataStringa = Console.ReadLine();
    dataFormattata = Convert.ToDateTime(dataStringa);

    // Ottengo la capienza della conferenza
    Console.WriteLine("Inserisci il numero di posti totali");
    capienzaMassima = Convert.ToInt32(Console.ReadLine());

    // Ottengo il nome del relatore
    Console.WriteLine("Inserisci il nome del relatore");
    string nomeRelatore = Console.ReadLine();

    // Ottengo il prezzo della conferenza
    Console.WriteLine("Inserisci il prezzo della conferenza");
    double prezzoConferenza = Convert.ToInt32(Console.ReadLine());

    // istanzio la nuova conferenza
    Conferenza nuovaConferenza = new Conferenza(nomeConferenza, dataFormattata, capienzaMassima, nomeRelatore, prezzoConferenza);

    // Aggiungo la conferenza al programma
    programmaEventi.AggiungiEvento(nuovaConferenza);

    // Stampo il programma creato
    Console.WriteLine("Il numero di eventi nel programma è " + programmaEventi.NumeroEventi());
    Console.WriteLine("Ecco il tuo programma eventi: ");
    Console.WriteLine(programmaEventi.ToString());

    // Ottengo la data da ricercare
    Console.WriteLine("inserisci una data per scoprire che eventi ci saranno (dd/MM/yyyy)");
    dataStringa = Console.ReadLine();
    dataFormattata = Convert.ToDateTime(dataStringa);

    // Stampo gli eventi relativi alla data
    Console.WriteLine("Ecco gli eventi relativi alla data che hai cercato: ");
    ProgrammaEventi.StampaListaEventi(programmaEventi.EventiPerData(dataFormattata));
}





















