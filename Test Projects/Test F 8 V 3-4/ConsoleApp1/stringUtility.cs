using System.Collections.Generic;

namespace ConsoleApp1
{
    public class stringUtility
    {
        public static string SummarizeText(string text, int maxLenth)
        {
            if (text.Length < maxLenth)
                return text;
            string[] words = text.Split(' ');
            int totalCharackters = 0;
            List<string> summaryWords = new List<string>();
            foreach (string word in words)
            {
                summaryWords.Add(word);
                totalCharackters += word.Length + 1;
                if (totalCharackters > maxLenth)
                    break;
            }
            return string.Join(" ", summaryWords) + "...";
        }
    }
}