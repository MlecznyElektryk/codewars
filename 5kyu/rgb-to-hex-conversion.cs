/* The rgb function is incomplete. 
 * Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. 
 * Valid decimal values for RGB are 0 - 255. 
 * Any values that fall out of that range must be rounded to the closest valid value.
 *Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.
*/

namespace rgb_to_hex_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Rgb(1,15, 255));
        }
        public static string Rgb(int r, int g, int b)
        {
            int[] temp = { r, g, b };
            string rgb = "";
            
            foreach(int t in temp)
            {
                if (t <= 0) rgb += "00";
                else if (t >= 255) rgb += "FF";
                else if (t > 0 && t <= 15) rgb += "0" + t.ToString("X");
                else rgb += t.ToString("X"); 
            }
            return rgb;
        }
    }

}