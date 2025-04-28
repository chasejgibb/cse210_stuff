using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "SkyNet";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Candy Man";
        job2._company = "tHe WOnKa fAcToRy";
        job2._startYear = 1001;
        job2._endYear = 3004;

        Resume resume1 = new Resume();
        resume1._name = "Average Intern";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}