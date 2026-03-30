using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.Clear();

        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial For Beginners - Learn C# Basics in 1 Hour", "Programming with Mosh", 4232);
        Comment comment1 = new Comment("Saeedhashemi1994", "thank u for teaching us in dark mode");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("AhmedOmar-th6ci", "never though i would be learning c# from Ian Hawk");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("xionic1194", "The first tutorial I have seen that tells you to go on stack overflow");
        video1.AddComment(comment3);


        Video video2 = new Video("Debugging C# Code in Visual Studio | Mosh", "Programming with Mosh", 1901);
        Comment comment4 = new Comment("michaelmiller7892", "Some of the most in-depth, easy-to-digest information on the subject I've seen. Thanks!");
        video2.AddComment(comment4);
        Comment comment5 = new Comment("yusef2610", "I always get happy when I search for C# guides and tips and Mosh shows up in the results. Big up!.");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("Aurigross", "CThank you Mosh for explaining in such a clear language, step by step all the small details.");
        video2.AddComment(comment6);

        Video video3 = new Video("C# Classes Tutorial | Mosh", "Programming with Mosh", 864);
        Comment comment7 = new Comment("ronancasey", "You're a great teacher :)");
        video3.AddComment(comment7);
        Comment comment8 = new Comment("brandonnorris1026", "Made me believe that I could use var to call a Class from anywhere on earth.");
        video3.AddComment(comment8);
        Comment comment9 = new Comment("josphatoluoch5205", "Thanks a lot, You are changing the world bro!! :D");
        video3.AddComment(comment9);

        videos.Add(video1 );
        videos.Add(video2);
        videos.Add(video3);

        int count = 1;

        foreach (Video v in videos)
        {
            Console.WriteLine($"Video  {count}");
            Console.WriteLine("");
            v.DisplayVideo();
            count++;
        }


    
    }
}