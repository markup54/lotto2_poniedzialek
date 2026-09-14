// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random  = new Random();

var liczba = 6; //typ rozpoznany po pierwszym uzyciu
int liczbaWylosowana = random.Next(1, 50);
int liczbaWylosowana2 = random.Next( 50);
//przeciążenie metody Next
//przeciążenie metody -> ta sama nazwa, różna liczba lub typ parametry
Console.WriteLine(liczbaWylosowana);

Console.WriteLine("podaj liczbę");
int liczbaWpisywana = int.Parse(Console.ReadLine());
//konwersja string na int
if(liczbaWpisywana == liczbaWylosowana)
{
    Console.WriteLine("Trafione");
}
else
{
    Console.WriteLine("Spróbuj jeszcze raz");
}

Console.WriteLine("zgadywanie 10 razy");
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Podaj " + i + " liczbę");
    liczbaWpisywana = int.Parse(Console.ReadLine());
    if(liczbaWylosowana == liczbaWpisywana)
    {
        Console.WriteLine("Udało się");
        break;
    }
    if (liczbaWpisywana > liczbaWylosowana)
    {
        Console.WriteLine("wpisano za dużo");
    }
    else
    {
        Console.WriteLine("wpisano za mało");
    }
}

Console.ReadLine();