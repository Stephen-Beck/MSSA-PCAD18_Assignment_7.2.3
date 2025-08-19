/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.
An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

    Example 1:
        Input: s = "anagram", t = "nagaram"
        Output: true

    Example 2:
        Input: s = "rat", t = "car"
        Output: false
 */

namespace Assignment_7._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"This program tests whether two strings are anagrams.
As anagrams usually ignore spaces, punctuation, and 
capitalization, they will be ignored in these tests
as well.
");
            
            string s = "anagram";
            string t = "nagaram";
            Test(s, t);

            s = "rat";
            t = "car";
            Test(s, t);

            s = "shell sort";
            t = "short sell";
            Test(s, t);

            s = " ";
            t = "";
            Test(s, t);

            s = "Listen";
            t = "Silent";
            Test(s, t);

            s = "abc123";
            t = "321cab";
            Test(s, t);

            s = "The eyes, ";
            t = "they see!";
            Test(s, t);

            s = "LeetCoder";
            t = "Electrode";
            Test(s, t);

            s = "Not an";
            t = "anagram!";
            Test(s, t);

            s = "rant";
            t = "trans";
            Test(s, t);
        }

        static void Test(string s, string t)
        {
            Console.WriteLine($"s = \"{s}\"");
            Console.WriteLine($"t = \"{t}\"");

            if (s.Trim() == "" && t.Trim() == "") Console.WriteLine("No words to compare!\n");
            else Console.WriteLine($"IsAnagram --> {IsAnagram(s, t)}\n");
        }
        static bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> sChars = new();
            Dictionary<char, int> tChars = new();

            // loop through each character in the string s (after removing all whitespace and making lowercase)
            foreach (char c in s.Trim().ToLower())
            {
                // check if character is letter or digit
                // anagrams can ignore spaces and punctuation
                if (Char.IsLetterOrDigit(c))
                {
                    if (sChars.ContainsKey(c)) sChars[c]++;
                    else sChars.Add(c, 1);
                }
            }

            // loop through each character in the string t (after removing all whitespace and making lowercase)
            foreach (char c in t.Trim().ToLower())
            {
                // check if character is letter or digit
                // anagrams can ignore spaces and punctuation
                if (Char.IsLetterOrDigit(c))
                {
                    if (tChars.ContainsKey(c)) tChars[c]++;
                    else tChars.Add(c, 1);
                }
            }

            // check that dictionaries sChars and tChars have the same number of keys
            if (sChars.Keys.Count != tChars.Keys.Count)
                return false;

            // check that dictionaries sChars and tChars keys and key values are the same
            foreach (var key in sChars.Keys)
            {
                if (tChars.ContainsKey(key))
                {
                    if (sChars[key] != tChars[key]) return false;
                }
                else return false;
            }

            return true;
        }
    }
}
