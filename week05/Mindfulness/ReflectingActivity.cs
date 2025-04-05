public class ReflectingActivity : Activity{

    private List<string>_prompts = new List<string>();
    private List<string>_questions = new List<string>();

    public ReflectingActivity(){
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;  

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run(){
        DisplayStartingMessage();

        DateTime currentDate = DateTime.Now;
        DateTime futureDate = currentDate.AddSeconds(_duration);

        Console.WriteLine("Consider the followind prompt:\n");
        DisplayPrompt();
        
        Console.WriteLine("When you have someting in mind, press enter to continue:");
        string answer = Console.ReadLine();

        if (answer == ""){
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(4);

            while (DateTime.Now < futureDate){
                DisplayQuestions();
        }

            DisplayEndingMessage();
        }
        else{
            Console.WriteLine("Sorry, invalid answer. Please try again.");
        }

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }

    public string GetRandomQuestion(){
        if (_questions.Count == 0)
        {
            Console.WriteLine("No more prompts available.");
            return string.Empty;
        }

        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        string randomPrompt = _questions[randomIndex];
        _questions.RemoveAt(randomIndex);
        return randomPrompt;
    }

    public void DisplayPrompt(){
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

    }


    public void DisplayQuestions(){
        Console.Write($"> {GetRandomQuestion()}? ");
        ShowSpinner(5);

    }
}