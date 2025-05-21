using System;
using System.Data;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        // Video 1
        string video1Title = "Outdoor Boys Farewell", video1Author = "Outdoor Boys";
        int video1Length = 600;
        List<string> video1Comments = new List<string>() {
            {"BoJangles:NOOOOOOOO"},
            {"RealDonaldTrump:What am I supposed to watch now before I go to bed?"},
            {"Bear Grylls:This guy was legit"},
            {"Real Martian Aliens:I hope this comment isn't used for some programming project" } };
        Video video1 = new Video(video1Title, video1Author, video1Length, video1Comments);

        // Video 2
        string video2Title = "How to make a black hole", video2Author = "DARPA DECLASSIFIED";
        int video2Length = 20;
        List<string> video2Comments = new List<string>()
        {
            {"James Bond:Instructions unclear, accidentally wiped the universe"},
            {"Bill Nye:Sure works. Kids loved it. Unsure as to where they went though."},
            {"Brother Parrish:Not sure why I'm commenting on this video after I've made a literal black hole. 2025 anyone?"},
        };
        Video video2 = new Video(video2Title, video2Author, video2Length, video2Comments);

        // Video 3 
        string video3Title = "Air breathing challenge (IMPOSSIBLE!)", video3Author = "MrBeast";
        int video3Length = 8372;
        List<string> video3Comments = new List<string>()
        {
            {"John Doe:I'm confused."},
            {"Chuck Norris:Air dosent keep me alive. I keep it alive."},
            {"Yo-Yo-Ma:I failed"},
            {"somerandomguy:Please give me a good grade Brother Parrish..."}
        };
        Video video3 = new Video(video3Title, video3Author, video3Length, video3Comments);

        Console.Clear();
        Console.WriteLine("Video 1:");
        video1.Display();
        Console.WriteLine("Video 2:");
        video2.Display();
        Console.WriteLine("Video 3:");
        video3.Display();
    }
}