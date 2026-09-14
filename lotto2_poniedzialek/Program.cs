// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random  = new Random();

var liczba = 6; //typ rozpoznany po pierwszym uzyciu
int liczbaWylosowana = random.Next(1, 50);
int liczbaWylosowana2 = random.Next( 50);
//przeciążenie metody Next
//przeciążenie metody -> ta sama nazwa, różna liczba lub typ parametry
Console.WriteLine(liczbaWylosowana);
Console.ReadLine();