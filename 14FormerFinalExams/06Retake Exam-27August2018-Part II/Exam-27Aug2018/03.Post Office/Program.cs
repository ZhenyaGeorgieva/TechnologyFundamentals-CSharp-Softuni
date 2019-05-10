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
            string patternCapitalLetters = @"([\#\$\%\*\&])(?<letters>[A-Z]{1,})\1";
            string patternCodeLength = @"(?<code>[0-9]{2}):(?<length>[0-9]{2})";
            string[] text = Console.ReadLine().Split(new char[] { '|' });

            string firstPart = text[0];
            string secondPart = text[1];
            string thirdPart = text[2];

            List<char> startingLetters = new List<char>();

            if (Regex.IsMatch(firstPart, patternCapitalLetters))
            {
                var collectionLetters = Regex.Matches(firstPart, patternCapitalLetters);
                foreach (Match item in collectionLetters)
                {
                    string matchedWord = item.Groups["letters"].Value.ToString();
                    for (int i = 0; i < matchedWord.Length; i++)
                    {
                        startingLetters.Add(matchedWord[i]);
                    }
                }
            }
            Dictionary<char, int> charsAndLength = new Dictionary<char, int>();
            if (Regex.IsMatch(secondPart, patternCodeLength))
            {
                var collectionLettersAndLength = Regex.Matches(secondPart, patternCodeLength);
                foreach (Match item in collectionLettersAndLength)
                {
                    char letter = (char)int.Parse(item.Groups["code"].Value.ToString());
                    int length = int.Parse(item.Groups["length"].Value.ToString());
                    charsAndLength[letter] = length + 1;
                }
            }
            string[] words = thirdPart.Split(new char[] { ' ' });
            Dictionary<char, int> finalCharsLength = new Dictionary<char, int>();
            foreach (var item in startingLetters)
            {
                char letterSought = item;
                foreach (var kvp in charsAndLength)
                {
                    char currentLetter = kvp.Key;
                    int currentLength = kvp.Value;
                    if (letterSought == currentLetter)
                    {
                        finalCharsLength[letterSought] = currentLength;
                    }
                }
            }
            foreach (var kvp in finalCharsLength)
            {
                char firstLetter = kvp.Key;
                int length = kvp.Value;
                for (int i = 0; i < words.Length; i++)
                {
                    string currentWord = words[i];
                    if (currentWord[0] == firstLetter
                        && currentWord.Length == length)
                    {
                        Console.WriteLine(currentWord);
                    }
                }
            }
        }
    }
}
