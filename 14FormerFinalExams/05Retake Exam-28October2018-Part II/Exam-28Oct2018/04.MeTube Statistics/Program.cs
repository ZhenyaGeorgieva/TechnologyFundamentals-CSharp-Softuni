using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, int> videoViews = new Dictionary<string, int>();
            Dictionary<string, int> videoLikes = new Dictionary<string, int>();

            while (command != "stats time")
            {
                if (command.Contains("-"))
                {
                    string[] tokens = command.Split("-");
                    string video = tokens[0];
                    int views = int.Parse(tokens[1]);
                    if (!videoViews.ContainsKey(video))
                    {
                        videoViews[video] = views;
                    }
                    else
                    {
                        videoViews[video] += views;
                    }
                    if (!videoLikes.ContainsKey(video))
                    {
                        videoLikes[video] = 0;
                    }
                }
                else if (command.Contains(":"))
                {
                    string[] tokens = command.Split(":");
                    if (tokens[0] == "like")
                    {
                        if (videoViews.ContainsKey(tokens[1]))
                        {
                            videoLikes[tokens[1]] += 1;
                        }
                    }
                    if (tokens[0] == "dislike")
                    {
                        if (videoViews.ContainsKey(tokens[1]))
                        {
                            videoLikes[tokens[1]] -= 1;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            string criterion = Console.ReadLine();
            if (criterion == "by views")
            {
                foreach (var kvp in videoViews.OrderByDescending(x => x.Value))
                {
                    string video = kvp.Key;
                    int views = kvp.Value;
                    int likes = videoLikes[video];
                    Console.WriteLine($"{video} - {views} views - {likes} likes");
                }
            }
            if (criterion == "by likes")
            {
                foreach (var kvp in videoLikes.OrderByDescending(x => x.Value))
                {
                    string video = kvp.Key;
                    int likes = kvp.Value;
                    int views = videoViews[video];
                    Console.WriteLine($"{video} - {views} views - {likes} likes");
                }
            }
        }
    }
}
