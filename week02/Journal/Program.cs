using System;

class Program
{
    static void Main(string[] args)
    { 

        Entry prompt1 = new Entry();
        prompt1._date = DateTime.Now.ToString("yyyy-MM-dd");
        prompt1._promptText = "Who had the most meaningful conversation with me today and why?";
        prompt1._entryText = Console.ReadLine();

        Entry prompt2 = new Entry();
        prompt2._date = DateTime.Now.ToString("yyyy-MM-dd");
        prompt2._promptText = "What small things brought me joy today?";
        prompt2._entryText = Console.ReadLine();

        Entry prompt3 = new Entry();
        prompt3._date = DateTime.Now.ToString("yyyy-MM-dd");
        prompt3._promptText = "What challenge taught me something valuable about myself?";
        prompt3._entryText = Console.ReadLine();

        Entry prompt4 = new Entry();
        prompt4._date = DateTime.Now.ToString("yyyy-MM-dd");
        prompt4._promptText = "Where did I feel my actions were most aligned with my values?";
        prompt4._entryText = Console.ReadLine();

        Entry prompt5 = new Entry();
        prompt5._date = DateTime.Now.ToString("yyyy-MM-dd");
        prompt5._promptText = "How can I use today's lessons to grow tomorrow?";
        prompt5._entryText = Console.ReadLine();

       Journal journal = new Journal();
       journal.AddEntry(prompt1);
       journal.AddEntry(prompt2);
       journal.AddEntry(prompt3);
       journal.AddEntry(prompt4);
       journal.AddEntry(prompt5);

       journal.DisplayAll();

    }
}