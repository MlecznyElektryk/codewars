//Move the first letter of each word to the end of it, then add "ay" to the end of the word.
//Leave punctuation marks untouched.

namespace simple_pig_latin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word= "Hello World !";
            word = pigIt(word);
            Console.WriteLine(word);
        }
        public static string pigIt(string str)
        {
            string[] words = str.Split(' ');

            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 1)
                {
                    if (char.IsPunctuation((words[i])[0]) == true)
                    {
                        continue;
                    }
                    else words[i] = words[i] + "ay";

                }

                words[i] = words[i] + words[i].Substring(0, 1) + "ay";
                words[i] = words[i].Remove(0, 1);
            }

            return String.Join(" ", words);
        }
    }
}