using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caeser_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];
            char.TryParse("a", out letters[0]);
            char.TryParse("b", out letters[1]);
            char.TryParse("c", out letters[2]);
            char.TryParse("d", out letters[3]);
            char.TryParse("e", out letters[4]);
            char.TryParse("f", out letters[5]);
            char.TryParse("g", out letters[6]);
            char.TryParse("h", out letters[7]);
            char.TryParse("i", out letters[8]);
            char.TryParse("j", out letters[9]);
            char.TryParse("k", out letters[10]);
            char.TryParse("l", out letters[11]);
            char.TryParse("m", out letters[12]);
            char.TryParse("n", out letters[13]);
            char.TryParse("o", out letters[14]);
            char.TryParse("p", out letters[15]);
            char.TryParse("q", out letters[16]);
            char.TryParse("r", out letters[17]);
            char.TryParse("s", out letters[18]);
            char.TryParse("t", out letters[19]);
            char.TryParse("u", out letters[20]);
            char.TryParse("v", out letters[21]);
            char.TryParse("w", out letters[22]);
            char.TryParse("x", out letters[23]);
            char.TryParse("y", out letters[24]);
            char.TryParse("z", out letters[25]);

            int shift = 0;
            while (shift > 25 || shift < 1)
            {
                Console.Clear();
                Console.WriteLine("Please the amount you want it to be shifted by? (1-24)");
                Int32.TryParse(Console.ReadLine(), out shift);
            }
            foreach (char letter in letters)
            {
                if ((letter + shift) < 26)
                {
                    letters[letter] = letters[letter + shift];
                }
                else
                {
                    letters[letter] = letters[letter + shift - 26];
                }
            }
            Console.WriteLine(letters);
            Console.WriteLine("Please enter a message");
            string messagestring = Console.ReadLine();
            char[] message = messagestring.ToCharArray();
            foreach (char letter in message)
            {
                
            }
            Console.ReadLine();
        }
    }
}
