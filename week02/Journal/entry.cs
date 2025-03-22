public class Entry{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(){
        PromptGenerator promptGenerator = new PromptGenerator();
        _promptText = promptGenerator.GetRadomPrompt(); 
        DateTime dateTime = DateTime.Now;
        _date = dateTime.ToShortTimeString();
    }

    public void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}\n");
    }
}

