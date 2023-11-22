/* Implement a function that receives two IPv4 addresses, 
and returns the number of addresses between them (including the first one, excluding the last one).
All inputs will be valid IPv4 addresses in the form of strings. 
The last address will always be greater than the first one.
*/
namespace count_ip_adresses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IpsBetween("10.0.0.0", "10.1.0.0"));
        }
        public static long IpsBetween(string start, string end)
        {
            string[] st = start.Split(".");
            string[] en = end.Split(".");
            long first = 0;
            long last = 0;

            for (int i = 0; i < 4; i++)
            {
                first += Convert.ToInt64(st[3 - i]) * Convert.ToInt64(Math.Pow(256, i));
                last += Convert.ToInt64(en[3 - i]) * Convert.ToInt64(Math.Pow(256, i));
            }
            return last - first;
        } 
    }
}