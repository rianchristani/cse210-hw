public class PromptGenerator{
    public List<string> _prompts = new List<string>();

    public PromptGenerator(){
        _prompts.Add("Who had the most meaningful conversation with me today and why?");  //1
        _prompts.Add("What small things brought me joy today?"); //2
        _prompts.Add("What challenge taught me something valuable about myself?"); //3
        _prompts.Add("Where did I feel my actions were most aligned with my values?"); //4
        _prompts.Add("How can I use today's lessons to grow tomorrow?"); //5
    }
    public string GetRadomPrompt(){
            Random random = new Random();
            int irandom = random.Next(_prompts.Count);
            string randomPrompt = _prompts[irandom];
            return randomPrompt;    
    }
}