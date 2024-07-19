public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity() {
        _name = "";
        _description = "";
        _duration = 0;


    }

    public void SetDuration()
    {
        Console.WriteLine("\nEnter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayStartMessage() {
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name}");
        Console.WriteLine(_description);
        SetDuration();
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage() {
        Console.WriteLine($"\n Well Done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.");    

    }

    public void ShowSpinner(int seconds) {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b"); // backspace
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b"); // backspace
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b"); // backspace
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b"); // backspace
        }
        Console.WriteLine("");

    }

    public void ShowCountDown(int seconds) {
        for (int i=1; i<=seconds; i++) {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
        
        
        Console.WriteLine("");
    }
}