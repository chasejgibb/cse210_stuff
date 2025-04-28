using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter your favorite numbers and we'll add them to a list! Enter 0 when you're done.");
        
        int num = 1;
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        int sum = numbers.Sum();
        double average = (double)sum / numbers.Count;
        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum of the list is: {sum}");
        Console.WriteLine($"The average of the list is: {average}");
        Console.WriteLine($"The max number of the list is: {max}");
    }
}