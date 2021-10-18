using System;
using System.Linq;
namespace LikesSystem
{

    class Likes
    {
        static void Main(string[] args)
        { 
        string abc = Console.ReadLine();

        string[] words = ProcessString(abc);
            string message = LikesNr(words);
            Console.WriteLine(message);

        }
        public static string LikesNr(string[] words)
        {
            if (words.Count() ==0)
            {
                return "No one likes this";
            }

            else if (words.Count() == 1)
            {
                return words[0] + " likes this";
            }

            else if (words.Count() == 2)
            {
                return words[0] + " and " + words[1] + " likes this";
            }

            else if (words.Count() == 3)
            {
                return words[0] +  " , " + words[1] + " and " + words[2] + " likes this";
            }

            else if (words.Count() > 3)
            {
                return words[0] + " , " + words[1] + " and " + (words.Length - 2) + " others likes this";
            }

            return string.Empty;

        }

        public static string[] ProcessString(string message)
        {
            return message.Split(',', ' ');
        }
    }

    
}

