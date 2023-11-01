/*Write a function that takes in a string of one or more words, and returns the same string, 
 *but with all five or more letter words reversed (Just like the name of this Kata). 
 *Strings passed in will consist of only letters and spaces. 
 *Spaces will be included only when more than one word is present.
*/

namespace stop_gninnipS_my_sdrow_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Hey fellow warriors";
            Console.WriteLine(spinWords(test));
        }
        public static string spinWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    words[i] = reverseString(words[i]);
                }
            }
            
            return string.Join(" ", words);
        }

        public static string reverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}