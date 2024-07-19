using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Oarabile Dilebo", "Math");
        Console.WriteLine(a1.GetSummary());

        
        MathAssignment a2 = new MathAssignment("Goerge ", "Fractions", "1.1", "3.2");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("The Portait of Dorian Gray", "Lord of the Rings", "Linkin Hypothesis");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}