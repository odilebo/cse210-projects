using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create and add videos
        Video video1 = new Video("Exploring the Mountains", "John Doe", 360);
        video1.AddComment(new Comment("Alice", "Amazing video!"));
        video1.AddComment(new Comment("Bob", "I love the scenery."));
        video1.AddComment(new Comment("Charlie", "Great work!"));
        videos.Add(video1);

        Video video2 = new Video("Cooking with Chef Mike", "Chef Mike", 540);
        video2.AddComment(new Comment("David", "This recipe is fantastic!"));
        video2.AddComment(new Comment("Eve", "I tried it and it was delicious."));
        video2.AddComment(new Comment("Frank", "Thanks for sharing."));
        videos.Add(video2);

        Video video3 = new Video("Tech Review: New Smartphone", "Tech Guru", 300);
        video3.AddComment(new Comment("Grace", "Very informative."));
        video3.AddComment(new Comment("Heidi", "I was thinking of buying this phone."));
        video3.AddComment(new Comment("Ivan", "Great review."));
        videos.Add(video3);

        Video video4 = new Video("Yoga for Beginners", "Yogi Anna", 420);
        video4.AddComment(new Comment("Jack", "This was really helpful."));
        video4.AddComment(new Comment("Kathy", "I feel so relaxed now."));
        video4.AddComment(new Comment("Leo", "Great session."));
        videos.Add(video4);

        // Display each video and its comments
        foreach (var video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}
