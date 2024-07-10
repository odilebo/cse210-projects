using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program");
        String choice; 
        do
        {
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("");

            choice = Console.ReadLine();
            if (choice == "1") 
            {
                
                
                journal.AddEntry();
                
                
                
                   


            }
            else if (choice == "2")
            {
                
                journal.DisplayAll();
            
                
            }  
            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename to load:");
                //string file = Console.ReadLine();
                journal.LoadTextFile();
                

            }
            else if(choice == "4")
            {
                Console.WriteLine("Enter the filename to save:");
                //string file = Console.ReadLine();

                journal.SaveTextFile();

            }
            else if(choice == "5")
            {
                Console.WriteLine("Goodbye");

            }

            else 
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine();

        }
        while (choice != "5"); 
       
        
    }
}