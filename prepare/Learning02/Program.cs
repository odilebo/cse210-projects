using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2022;
        

        
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Sales Executive";
        job2._startYear = 2010;
        job2._endYear = 2023;
        

        Resume myResume = new Resume();
        myResume._name = "Oarabile Dilebo";

        myResume._listJobs.Add(job1);
        myResume._listJobs.Add(job2);

        myResume.Display();
        
    }
}
