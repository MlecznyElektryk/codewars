/* Write a function that accepts an array of 10 integers (between 0 and 9)
 *that returns a string of those numbers in the form of a phone number "(000) 000-0000".
 */
namespace create_phone_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine (createPhoneNumber (numbers));
        }
        public static string createPhoneNumber(int[] numbers)
        {
            string number = "(";

            for (int i = 0; i< numbers.Length; i++)
            {
                if (i == 3) number += ") ";
                if (i == 6) number += "-";
                number += numbers[i]; 
            }
            return number;
        }
    }
}