using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello world! :)");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            return username;
        }
        
        static int PromptUserNumber(string username)
        {
            Console.Write($"What's your favorite number, {username}? ");
            int favNum = int.Parse(Console.ReadLine());
            return favNum;
        }

        static int SquareNumber(int number)
        {
            int sqrdNum = number * number;
            return sqrdNum;
        } 

        static void DisplayResult(string username, int sqrdNum)
        {
            Console.WriteLine($"{username}, the square of your number is {sqrdNum}");
        }

        static void Main()
        {
            DisplayWelcome();
            string username = PromptUserName();
            int num = PromptUserNumber(username);
            int sqrdNum = SquareNumber(num);
            DisplayResult(username, sqrdNum);
        }
        Main();
    }
}