using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseNesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursOfSleep = 5;

            if (hoursOfSleep > 9)
            {
                Console.WriteLine("Wow, thats a lot of sleep");
            }
            else if(hoursOfSleep == 9)
            {
                Console.WriteLine("You are well rested");
            }
            else if (hoursOfSleep / 4 == 1)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Get Some Sleep");
            }

            string superLongString = "thisisaveryverylongstringwithmanyvowels";
            foreach (char letter in superLongString)
                if (letter == 'a')
                    Console.WriteLine(letter);
        }
    }
}
