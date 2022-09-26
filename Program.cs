using System;
/*
string risposta;

Console.WriteLine("inserisci il titolo del nuovo evento");
string titolo = Console.ReadLine();

Console.WriteLine("inserisci la data dell'evento");
string data = Console.ReadLine();
DateTime dataEvento = Convert.ToDateTime(data);

Console.WriteLine("inserisci la capienza massima");
int capienza = Convert.ToInt32(Console.ReadLine());

Evento evento = new Evento(titolo, dataEvento, capienza);

Console.WriteLine("quante prenotazioni vuoi effettuare?");

int prenotazioni = Convert.ToInt32(Console.ReadLine());

evento.PrenotaPosti(prenotazioni);

Console.WriteLine("sono stati prenotati " + evento.PostiPrenotati + " posti");

Console.WriteLine("vuoi disdire dei posti? (si/no)");
risposta = Console.ReadLine();

while(risposta == "si")
{
    Console.WriteLine("quanti posti vuoi disdire?");
    int postiDisdetti = Convert.ToInt32(Console.ReadLine());
    evento.DisdiciPosti(postiDisdetti);

    Console.WriteLine("sono stati prenotati " + evento.PostiPrenotati + " posti");

    Console.WriteLine("i posti disponibili sono: " + evento.GetPostiDisponibili());

    Console.WriteLine("vuoi disdire dei posti? (si/no)");
    risposta = Console.ReadLine();

}
*/

// ottengo il nome del programma eventi
Console.WriteLine("Inserisci il nome del tuo programma eventi");
string nomeProgramma = Console.ReadLine();

// istanzio il nuovo programma
ProgrammaEventi programmaEventi = new ProgrammaEventi(nomeProgramma);

// ottengo il numero degli eventi
Console.WriteLine("Quanti eventi vuoi inserire?");
int numeroEventi = Convert.ToInt32(Console.ReadLine());  

// ciclo per ogni evento
for(int i = 0; i < numeroEventi; i++)
{
    // ottengo il nome del singolo evento
    Console.WriteLine("Inserisci il nome del "+ (i+1) +"° evento: ");
    string nomeEvento = Console.ReadLine();

    // ottengo la data del singolo evento
    Console.WriteLine("Inserisci la data dell'evento (dd/MM/yyyy)");
    string dataStringa = Console.ReadLine();
    DateTime dataFormattata = Convert.ToDateTime(dataStringa);

    // ottengo la capienza del singolo evento
    Console.WriteLine("Inserisci il numero di posti totali");
    int capienzaMassima = Convert.ToInt32(Console.ReadLine());

    // istanzio il nuovo evento
    Evento nuovoEvento = new Evento(nomeEvento, dataFormattata, capienzaMassima);

    // aggiungo l'evento al programma
    programmaEventi.AggiungiEvento(nuovoEvento);
}

// stampo il programma creato
Console.WriteLine("Il numero di eventi nel programma è " + programmaEventi.NumeroEventi());
Console.WriteLine("Ecco il tuo programma eventi: ");
Console.WriteLine(programmaEventi.Titolo);
Console.WriteLine(programmaEventi.ToString());

// ottengo la data da ricercare
Console.WriteLine("inserisci una data per scoprire che eventi ci saranno (dd/MM/yyyy");
string data = Console.ReadLine();
DateTime dataEvento = Convert.ToDateTime(data);

// stampo gli eventi relativi alla data
Console.WriteLine("Ecco gli eventi relativi alla data che hai cercato: ");
ProgrammaEventi.StampaListaEventi(programmaEventi.EventiPerData(dataEvento));

















