using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal static class Data
    {
        private static string playerName = String.Empty;
        public static string PlayerName 
        { 
            get 
            { 
                return playerName; 
            } 
            set
            {
                playerName = value;
            }
        }
        public static string GetResults()
        {
            using (StreamReader ofstream = new StreamReader("Results.TXT"))
            {
                string results = String.Empty;
                while (ofstream.EndOfStream == false)
                {
                    results = string.Concat(results, ofstream.ReadLine(), Environment.NewLine);
                }
                return results;
            }
        }

        public static void AddResult(string playerName, int score)
        {
            using (StreamWriter ofstream = new StreamWriter("Results.TXT", true))
            {
                ofstream.WriteLine($"{playerName} {score} {DateTime.Now}");
            }
        }

    }
}
