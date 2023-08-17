using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            String soonglyrics = "you say goodbye, and i say hello";
            Console.WriteLine(soonglyrics.StartsWith("you"));
            Console.WriteLine(soonglyrics.EndsWith("goodbye"));
        }
    }
}
