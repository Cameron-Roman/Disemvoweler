using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvowler
{
    class Program
    {
        static string Disemvowler(string inString)
        {
            string vowels = "";
            string ReturnString = "";
            var counter = 0;
            for (var i = 0; i < inString.Length; i++)
            {
                var c = inString[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowels += c;
                }
                else if (c == ' ')
                {
                    counter += 1;
                }
                else
                {
                    ReturnString += c;
                }
            }
            return ReturnString;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("nickelback is my favorite band. Their songwriting can't be beat!");
            Disemvowler("nickelback is my favorite band. Their songwriting can't be beat!");
            Console.WriteLine("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvowler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Console.WriteLine("I'm a code ninja,baby. I make the functions and I make the calls.");
            Disemvowler("I'm a code ninja,baby. I make the functions and I make the calls.");
            Console.ReadKey();
        }

            
    }

}


