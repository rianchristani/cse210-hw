using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        write write1 = new write();
        write1._sentence = "Who had the most meaningful conversation with me today and why?";

        write write2 = new write();
        write2._sentence = "What small things brought me joy today?";

        write write3 = new write();
        write3._sentence = "What challenge taught me something valuable about myself?";

        write write4 = new write();
        write4._sentence = "Where did I feel my actions were most aligned with my values?";

        write write5 = new write();
        write5._sentence = "How can I use today's lessons to grow tomorrow?";

        display display = new display();
        display._sentences.Add(write1);
        display._sentences.Add(write2);
        display._sentences.Add(write3);
        display._sentences.Add(write4);
        display._sentences.Add(write5);

        display.Display();
    }
}