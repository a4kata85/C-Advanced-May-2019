using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._The_V_Logger
{
    class VLoggers
    {
        static void Main()
        {
            HashSet<string> usernames = new HashSet<string>();
            var userFollowers = new Dictionary<string, HashSet<string>>();
            var userFollowing = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Statistics")
                {
                    break;
                }

                string[] splitedInput = input.Split();
                if (splitedInput.Length == 4)
                {
                    string userName = splitedInput[0];

                    if (usernames.Contains(userName) == false)
                    {
                        usernames.Add(userName);
                        userFollowers.Add(userName, new HashSet<string>());
                        userFollowing[userName] = new HashSet<string>();
                    }
                    
                }
                else
                {
                    //Saffrona followed EmilConrad
                    string heFollows = splitedInput[0];
                    string followed = splitedInput[2];

                    if (usernames.Contains(heFollows) && usernames.Contains(followed) && heFollows != followed)
                    {
                        userFollowers[followed].Add(heFollows);
                        userFollowing[heFollows].Add(followed);
                    }
                }


            }

            Console.WriteLine($"The V-Logger has a total of {usernames.Count} vloggers in its logs.");
            var topUser = userFollowers
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => userFollowing[x.Key].Count()).FirstOrDefault();

            Console.WriteLine($"1. {topUser.Key} : {topUser.Value.Count} followers, {userFollowing[topUser.Key].Count} following");

            foreach (var userName in topUser.Value.OrderBy(a => a))
            {
                Console.WriteLine($"*  {userName}");
            }

            int count = 2;
            foreach (var kvp in userFollowers.Where(x => x.Key != topUser.Key)
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => userFollowing[x.Key].Count()))
            {
                Console.WriteLine($"{count}. {kvp.Key} : {kvp.Value.Count} followers, {userFollowing[kvp.Key].Count} following");
                count++;
            }
        }
    }
}
