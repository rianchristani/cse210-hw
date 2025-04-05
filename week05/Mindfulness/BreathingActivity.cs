public class BreathingActivity : Activity{
    
    public BreathingActivity(){
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;    
    }

    public void Run(){
        DisplayStartingMessage();

        DateTime currentDate = DateTime.Now;
        DateTime futureDate = currentDate.AddSeconds(_duration);

        while (DateTime.Now < futureDate){
            Console.Write("\nBreathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
