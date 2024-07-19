using System;

public class BreathingActivity : Activity {

    public BreathingActivity() {
        _name = "\nBreathing Activity";
        _description = "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void Run() {
        
        DisplayStartMessage();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountDown(5);
            Console.WriteLine("\nBreathe out...");
            ShowCountDown(5);
        }

        DisplayEndingMessage();

    }


}