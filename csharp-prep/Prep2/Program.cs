using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);
        string letter = "";

        if (numberGrade >= 90)
        {
            letter = "A";
        }

        else if (numberGrade >= 80)
        {
            letter = "B";
        }

        else if (numberGrade >= 70)
        {
            letter = "C";
        }

        else if (numberGrade >= 60)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}");

        if (numberGrade >=70)
        {
            Console.WriteLine("Congratulations You passed!");
        }

        else 
        {
            Console.WriteLine("Dont give up, There is always a next time!");
        }
    }
}