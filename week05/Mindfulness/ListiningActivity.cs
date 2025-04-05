using System.IO.Compression;

public class ListiningActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _userAnswers = new List<string>();

    public ListiningActivity()
    {
        _name = "Listining";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime currentDate = DateTime.Now;
        DateTime futureDate = currentDate.AddSeconds(_duration);

        Console.WriteLine("List as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(4);

        while (DateTime.Now < futureDate)
        {
            GetListFromUser();
        }

        Console.WriteLine($"You listed {_userAnswers.Count} items!");

        Console.WriteLine("\nThis is your list:\n");
        foreach(string listAnswers in _userAnswers){
            Console.WriteLine($"- {listAnswers}");
        }

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int irandom = random.Next(_prompts.Count);
        string randomPrompt = _prompts[irandom];
        Console.WriteLine($"--- {randomPrompt} ---");
    }

    public List<string> GetListFromUser()
    {
        Console.Write("\n> ");
        string answer = Console.ReadLine();
            _userAnswers.Add(answer);

        return _userAnswers;
    }
}