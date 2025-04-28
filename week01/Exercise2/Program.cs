using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your grade as an integer: ");
        string gradeStr = Console.ReadLine();
        int grade = int.Parse(gradeStr);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        } 
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Grade: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congragulations, you didn't fail! You should be SO proud of yourself");
        }
        else
        {
            Console.WriteLine("You uh.. didn't pass. Better luck next time.");
        }
    }
}