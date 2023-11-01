/*There is an array with some numbers. 
 *All numbers are equal except for one. Try to find it!
 *It’s guaranteed that array contains at least 3 numbers.
*/
namespace find_the_unique_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 2, 3, 2, 2, 2, 2, 2, };
            Console.WriteLine("Odd number is " +  getUnique(number));
            
        }
        public static int getUnique(IEnumerable<int> numbers)
        {
            int basic;

            if (numbers.ElementAt(0) == numbers.ElementAt(1)) basic = numbers.ElementAt(0);
            else if (numbers.ElementAt(1) == numbers.ElementAt(2)) basic = numbers.ElementAt(1);
            else basic = numbers.ElementAt(2);

            foreach (int number in numbers)
            {
                if (number != basic) return number;
            }

            return -1;
        }
    }
}