using System;

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

do
{
    Console.WriteLine("vuoi disdire dei posti? (si/no)");
    risposta = Console.ReadLine();

    Console.WriteLine("quanti posti vuoi disdire?");
    int postiDisdetti = Convert.ToInt32(Console.ReadLine());
    evento.DisdiciPosti(postiDisdetti);

    Console.WriteLine("sono stati prenotati " + evento.PostiPrenotati + " posti");

} while (risposta == "si");












