using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all the videos
        List<Video> videos = new List<Video>();

        // --- Video 1 ---
        Video video1 = new Video("Intro to C#", "CodeGuru", 600);
        video1.AddComment(new Comment("John Smith", "Great tutorial, very clear!"));
        video1.AddComment(new Comment("Jane Doe", "Learned a lot, thanks!"));
        video1.AddComment(new Comment("Peter Muli", "What about generics?"));
        videos.Add(video1);

        // --- Video 2 ---
        Video video2 = new Video("Building a React App", "WebDevMaster", 1200);
        video2.AddComment(new Comment("Mike Brown", "The project was fun to build."));
        video2.AddComment(new Comment("Emily Gondwe", "Could you do a video on state management?"));
        video2.AddComment(new Comment("Sam Saidi", "Nice explanation of hooks!"));
        videos.Add(video2);

        // --- Video 3 ---
        Video video3 = new Video("Data Structures in Python", "PythonPal", 900);
        video3.AddComment(new Comment("Sarai Tambo", "This helped me with my homework!"));
        video3.AddComment(new Comment("David Lemusi", "Super helpful, thanks for the examples."));
        videos.Add(video3);

        // Iterate through the list of videos and display their information
        foreach (Video video in videos)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            // Iterate through the comments for the current video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(); // Add a blank line for readability
        }    
    }
}