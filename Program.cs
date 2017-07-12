using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can do it, girl!");

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Amy"},
                {"age", "30"}
            });
            myFamily.Add("mother", new Dictionary<string, string>(){ 
                {"name", "Julie"},
                {"age", "59"}
            });
            myFamily.Add("father", new Dictionary<string, string>(){ 
                {"name", "Newell"},
                {"age", "55"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Wesley"},
                {"age", "28"}
            });

            foreach( KeyValuePair<string, Dictionary<string, string>> kvp in myFamily )
            {
                Console.WriteLine($"{kvp.Value["name"]} is my {kvp.Key} and is {kvp.Value["age"]} years old.");
            }

        }
    }
}
