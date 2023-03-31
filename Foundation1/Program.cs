using System;

class Program
{
    static void Main(string[] args)
    {
        Videos v1 = new Videos("Car Chase", "Aaron Andersen", 343);
        Comments c11 = new Comments("Arthur Peterson", "Woah! It is so realistic!");
        Comments c12 = new Comments("James Jones", "Nice action!");
        Comments c13 = new Comments("Brian Day", "I love it!");
        v1._comments.Add(c11);
        v1._comments.Add(c12);
        v1._comments.Add(c13);

        Videos v2 = new Videos("NBA Highlights", "Mark Jones", 427);
        Comments c21 = new Comments("Justin Johnson", "I didn't see this game");
        Comments c22 = new Comments("James Jones", "Impressive dunk");
        Comments c23 = new Comments("Ryan Long", "GO MAVS!");
        v2._comments.Add(c21);
        v2._comments.Add(c22);
        v2._comments.Add(c23);

        Videos v3 = new Videos("Brief History of USA", "Sarah Clark", 1204);
        Comments c31 = new Comments("Ryan Johns", "I had no idea");
        Comments c32 = new Comments("Hyrum Redmond", "Fasinating");
        Comments c33 = new Comments("Bruce Davis", "Great presentation!");
        v3._comments.Add(c31);
        v3._comments.Add(c32);
        v3._comments.Add(c33);

        List<Videos> videos = new List<Videos>();

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach(Videos video in videos)
        {
            Console.WriteLine($"Video: {video._title}: {video._author}, {video._length}sec, Comments: {video.GetCommentNum()}");
            Console.WriteLine();
            video.GetComments();
            Console.WriteLine();
        }
    }
}