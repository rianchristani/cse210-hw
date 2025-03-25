using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello! Welcome to 'Scripture Memorizer'! Plase, before we begin, enter the scripturar that would you like to memorize:");
        Console.WriteLine("Please, give the folowings informations:");

        Console.WriteLine("Book: ");
        string book = Console.ReadLine();

        Console.WriteLine("Chapter: ");
        string chapter = Console.ReadLine();
        int chapterN = int.Parse(chapter);

        Console.WriteLine("Initial verse: ");
        string iVerse = Console.ReadLine();
        int iVerseM = int.Parse(iVerse);

        Console.WriteLine("Last Verse: ");
        string lVerse = Console.ReadLine();
        int lVerseN = int.Parse(lVerse);

        Console.WriteLine("Sriputre text: ");
        string scriptureText = Console.ReadLine();

        Reference reference = new Reference(book,chapterN,iVerseM,lVerseN);
        Scripture scripture = new Scripture(reference, scriptureText);

        string answer = "";

        while (answer != "quit" && !scripture.IsCompletelyHidden()){
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            scripture.GetDisplayText();

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
            scripture.HideRandomWords(3);
        }

            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            scripture.GetDisplayText();
    }
}