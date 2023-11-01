namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "radar";
            Console.WriteLine($"Is {word} palindrome? {isPalindrome(word)}");
        }
        static bool isPalindrome(string word)
        {
            char[] temp = word.ToCharArray();
            Array.Reverse(temp);
            return (new string(temp) == word) ? true : false;
        }
    }
}