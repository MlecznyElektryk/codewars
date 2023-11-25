/*Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, 
  otherwise returns false.
  Only lower case letters will be used (a-z). No punctuation or digits will be included.
  Performance needs to be considered.
*/

namespace scramblies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scramble("katas", "steak"));
        }
        public static bool Scramble(string str1, string str2)
        {
            int count = 0;
            char[] temp = str2.ToCharArray();

            for (int i = 0; i < str1.Length; i++)
            {
                for(int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == temp[j])
                    {
                        count++;
                        temp[j] = '-';
                        break;
                    }
                }
                if (count == str2.Length) return true;
            }
            return false;
        }
    }
}