using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Basics", "John Smith", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks for sharing."));

        Video video2 = new Video("OOP Explained", "Sarah Johnson", 850);
        video2.AddComment(new Comment("David", "Excellent explanation."));
        video2.AddComment(new Comment("Emma", "I understand OOP now."));
        video2.AddComment(new Comment("Frank", "Very informative."));

        Video video3 = new Video("Data Structures", "Mike Brown", 720);
        video3.AddComment(new Comment("Grace", "Awesome content."));
        video3.AddComment(new Comment("Henry", "Please make more videos."));
        video3.AddComment(new Comment("Ivy", "This helped me study."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}