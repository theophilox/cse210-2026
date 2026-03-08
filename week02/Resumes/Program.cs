using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Japanese Car Parts";
        job1._jobTitle = "Industrial Packager";
        job1._startYear = 2017;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Integrated Precision Incorporation";
        job2._jobTitle = "Production Operator";
        job2._startYear = 2015;
        job2._endYear = 2017;

        job1.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Nathan Javier";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);


        myResume.DisplayResumeDetails();







    }

}