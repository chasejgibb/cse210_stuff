using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathHomework = new MathAssignment("Charlie", "Algebra", "8.3", "1-12");
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());

        WritingAssignment englishHomework = new WritingAssignment("Stephen King", "Creative Writing", "Horror Stories for Toddlers");
        Console.WriteLine(englishHomework.GetSummary());
        Console.WriteLine(englishHomework.GetWritingInformation());
    }
}










