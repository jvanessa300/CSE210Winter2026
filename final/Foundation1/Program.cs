
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Bake Chocolate Chip Cookies", "Sarah Cooks", 540);
        video1.AddComment(new Comment("Emma", "These cookies turned out amazing!"));
        video1.AddComment(new Comment("Noah", "Thanks for the clear instructions."));
        video1.AddComment(new Comment("Lily", "I added walnuts and they were so good."));

        Video video2 = new Video("Beginner C# Tutorial", "Code Academy", 1200);
        video2.AddComment(new Comment("James", "This helped me understand classes."));
        video2.AddComment(new Comment("Ava", "Best beginner tutorial I have found."));
        video2.AddComment(new Comment("Mason", "Can you make one on inheritance next?"));

        Video video3 = new Video("Morning Workout Routine", "Fit With Mia", 900);
        video3.AddComment(new Comment("Sophia", "I felt great after this workout."));
        video3.AddComment(new Comment("Ethan", "Perfect routine before work."));
        video3.AddComment(new Comment("Isabella", "I like how simple this was to follow."));

        Video video4 = new Video("Study Tips for College Students", "Campus Success", 720);
        video4.AddComment(new Comment("Lucas", "The time blocking tip was really helpful."));
        video4.AddComment(new Comment("Mia", "I am going to try these this semester."));
        video4.AddComment(new Comment("Benjamin", "Very motivating video."));

        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}