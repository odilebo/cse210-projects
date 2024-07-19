using System;

class Program
{
    static void Main(string[] args)
    {
        var choice ="";
        do
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start breathing activity ");
            Console.WriteLine(" 2. Start reflecting activity  ");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine("\nSelect a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                // breathingActivity.DisplayStartMessage();
                // breathingActivity.DisplayEndingMessage();
                // breathingActivity.ShowSpinner(5);
                // breathingActivity.ShowCountDown(5);

            }
            if (choice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();   
            }
            if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();   
            }
            if (choice == "4")
            {
                Console.WriteLine("\nGoodbye");
            }
            else
            {
                Console.WriteLine("\nInvalid Choice. Try Again");

            }
            
            
        } 
        while (choice != "4");
            
    } 
        
        
        
        
        
}