using System.Collections;

namespace CSharp_Oppgaver;

class Program
{
    static void Main(string[] args)
    {

        /* ----------------------------------------------------------------------------
                                            OPPGAVE 2
        ---------------------------------------------------------------------------- */
        //Lag en variabel av datatypen integer og tildel den et vilkårlig heltall
        int num1 = 10;

        //Lag en variabel av datatypen string og tilden en vilkårlig tekst
        string string1 = "Hei på deg";

        //Lag en variabel av datatypen double og tilden et vilkårlig tall, både desimal og heltall er gyldig med denne typen
        double dblNum1 = 6.9;

        //Lag en variabel av datatypen char og tildel den en vilkårlig karakter(bokstav eller tall)
        char char1 = 'A';

        //Lag et Array av datatypen integer og skriv ut verdiene med en vanlig for-løkke
        int[] tabell1 = { 37, 82, 54, 19, 63, 91, 27, 48, 75, 11, 8, 62, 23, 94, 36, 58, 50, 64, 77, 10 };

        for (int i = 0; i < tabell1.Length; i++)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine("");

        //Lag et Array av datatypen string og skriv ut verdiene med en foreach-løkke
        string[] tabell2 = { "apple", "mountain", "galaxy", "river", "shadow", "bicycle", "melody", "sunshine", "paper", "crystal", "wisdom", "forest", "journey", "laughter", "candle", "ocean", "harmony", "freedom", "adventure" };

        foreach (string i in tabell2)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine("");

        //Lag en List av datatypen string og tildel verdier ved hjelp av metoden myExampleList.Add("min string");
        //Legg til flere strings i listen deres
        ArrayList liste1 = new ArrayList();

        liste1.Add("Nasir");
        liste1.Add("Eple");
        liste1.Add("Mercedes");
        liste1.Add("Sykkel");
        liste1.Add("Mus");
        liste1.Add("Sko");

        //Skriv ut verdiene i listen ved hjelp av en foreach-løkke
        foreach (var i in liste1)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("");


        /* ----------------------------------------------------------------------------
                                            OPPGAVE 3
        ---------------------------------------------------------------------------- */

        //Lag en Dictionary med integer-nøkkel og string-verdi slik
        //Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        myDictionary.Add(1, "Hei hei");
        myDictionary.Add(2, "Hadet");
        myDictionary.Add(420, "Crazy");

        //Skriv ut verdiene i Dictionary ved å anvende en foreach-løkke ved hjelp av datatypen var
        foreach (var i in myDictionary)
        {
            Console.WriteLine(i);
        }

        //Lag en metode av typen integer som legger sammen to tall, int a og int b
        Console.WriteLine(Calculate(2, 7));

        ////Lag en metode av typen string som skrive ut en liten hilsen til brukeren ved å bruke en parametervariabel.
        Console.WriteLine(Greetings("Nasir"));

    }
    public static double Calculate(int a, int b)
    {
        return a + b;
    }

    public static string Greetings(string navn)
    {
        return $"Hei, {navn} {Emoji.Blush}";
    }
}
