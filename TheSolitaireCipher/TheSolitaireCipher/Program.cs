using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSolitaireCipher
{
    public class Program
    {
        static void Main(string[] args)
        {
            String fives = FormatInput.MakeDivisibleByFive();
            Console.WriteLine(fives);
            Console.ReadKey();
        }
    }
}
