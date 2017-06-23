using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpIntermediateSection1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stopwatch class testing:");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Thread.Sleep(5000);
            TimeSpan duration = watch.Stop();
            Console.WriteLine("Time passed: " + duration.TotalSeconds);

            Console.WriteLine("");

            Console.WriteLine("Post class testing:");
            Post post = new Post("Test post!", "This is a test post.", DateTime.Now);
            post.Upvote();
            post.Upvote();
            post.Upvote();
            post.Downvote();
            Console.WriteLine("Post score: " + post.PostScore);

            Console.ReadKey();
        }
    }
}
