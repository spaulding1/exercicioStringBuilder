using CursoCsharp.Entities;
using System;

namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");
            Post p1 = new Post(
                    DateTime.Parse("13/02/2020 13:05:44"),
                    "Traveling to New Zealand",
                    "I'm going to visit this wonderful country",
                    12
                );
            p1.ADDComment(c1);
            p1.ADDComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                    DateTime.Parse("23/03/2020 12:15:00"),
                    "Good night guys",
                    "See you tomorrow",
                    5
                );
            p2.ADDComment(c3);
            p2.ADDComment(c4);


            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
