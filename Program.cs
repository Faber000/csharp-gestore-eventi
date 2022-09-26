using System;

string risposta;
string nomeEvento, dataStringa;
DateTime dataFormattata;
int capienzaMassima;

// Menu 
Console.WriteLine("Inserisci 1 per creare un singolo evento");
Console.WriteLine("Inserisci 1 per creare un programma di eventi");
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
    // ottengo il nome del nuovo evento
    Console.WriteLine("Inserisci il titolo del nuovo evento");
    nomeEvento = Console.ReadLine();

    // ottengo la data dell'evento
    Console.WriteLine("Inserisci la data dell'evento");
    dataStringa = Console.ReadLine();
    dataFormattata = Convert.ToDateTime(dataStringa);

    // ottengo la capienza massima dell'evento
    Console.WriteLine("Inserisci la capienza massima");
    capienzaMassima = Convert.ToInt32(Console.ReadLine());

    // istanzio il nuovo evento
    Evento evento = new Evento(nomeEvento, dataFormattata, capienzaMassima);

    // ottengo il numero di prenotazioni
    Console.WriteLine("Quante prenotazioni vuoi effettuare?");
    int numeroPrenotazioni = Convert.ToInt32(Console.ReadLine());

    // effettuo la prenotazione
    evento.PrenotaPosti(numeroPrenotazioni);

    Console.WriteLine("sono stati prenotati " + evento.PostiPrenotati + " posti");

    Console.WriteLine("vuoi disdire dei posti? (si/no)");
    risposta = Console.ReadLine();

    while (risposta == "si")
    {
        // ottengo il numero di posti da disdire
        Console.WriteLine("quanti posti vuoi disdire?");
        int postiDisdetti = Convert.ToInt32(Console.ReadLine());

        // disdico i posti
        evento.DisdiciPosti(postiDisdetti);

        Console.WriteLine("sono stati prenotati " + evento.PostiPrenotati + " posti");

        Console.WriteLine("i posti disponibili sono: " + evento.GetPostiDisponibili());

        Console.WriteLine("vuoi disdire dei posti? (si/no)");

        risposta = Console.ReadLine();
    }
}

void CreaProgrammaEventi()
{
    // ottengo il nome del programma eventi
    Console.WriteLine("Inserisci il nome del tuo programma eventi");
    string nomeProgramma = Console.ReadLine();

    // istanzio il nuovo programma
    ProgrammaEventi programmaEventi = new ProgrammaEventi(nomeProgramma);

    // ottengo il numero degli eventi
    Console.WriteLine("Quanti eventi vuoi inserire?");
    int numeroEventi = Convert.ToInt32(Console.ReadLine());

    // ciclo per ogni evento
    for (int i = 0; i < numeroEventi; i++)
    {
        // ottengo il nome del singolo evento
        Console.WriteLine("Inserisci il nome del " + (i + 1) + "° evento: ");
        nomeEvento = Console.ReadLine();

        // ottengo la data del singolo evento
        Console.WriteLine("Inserisci la data dell'evento (dd/MM/yyyy)");
        dataStringa = Console.ReadLine();
        dataFormattata = Convert.ToDateTime(dataStringa);

        // ottengo la capienza del singolo evento
        Console.WriteLine("Inserisci il numero di posti totali");
        capienzaMassima = Convert.ToInt32(Console.ReadLine());

        try
        {
            // istanzio il nuovo evento
            Evento nuovoEvento = new Evento(nomeEvento, dataFormattata, capienzaMassima);

            // aggiungo l'evento al programma
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

    // stampo il programma creato
    Console.WriteLine("Il numero di eventi nel programma è " + programmaEventi.NumeroEventi());
    Console.WriteLine("Ecco il tuo programma eventi: ");
    Console.WriteLine(programmaEventi.Titolo);
    Console.WriteLine(programmaEventi.ToString());

    // ottengo la data da ricercare
    Console.WriteLine("inserisci una data per scoprire che eventi ci saranno (dd/MM/yyyy)");
    dataStringa = Console.ReadLine();
    dataFormattata = Convert.ToDateTime(dataStringa);

    // stampo gli eventi relativi alla data
    Console.WriteLine("Ecco gli eventi relativi alla data che hai cercato: ");
    ProgrammaEventi.StampaListaEventi(programmaEventi.EventiPerData(dataFormattata));
}





















