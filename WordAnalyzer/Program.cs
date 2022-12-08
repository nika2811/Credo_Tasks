using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WordStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read all the words
            string[] words = File.ReadAllText("words_alpha.txt")
                                 .Split(new char[] { ' ', '\n', '\r' },
                                         StringSplitOptions.RemoveEmptyEntries);

            //Shortest and longest words 
            string shortestWord = words.AsParallel()
                                       .OrderBy(w => w.Length)
                                       .First();
            string longestWord = words.AsParallel()
                                      .OrderBy(w => w.Length)
                                      .Last();

            Console.WriteLine($"Shortest word: {shortestWord}");
            Console.WriteLine($"Longest word: {longestWord}");

            // 100 words with the most vowels 
            var wordsWithMostVowels = words.AsParallel()
                                           .OrderByDescending(w => w.Count(c => "aeiou".Contains(c)))
                                           .Take(100);

            Console.WriteLine("100 words with the most vowels:");
            foreach (var word in wordsWithMostVowels)
            {
                Console.WriteLine(word);
            }
        }
    }
}
