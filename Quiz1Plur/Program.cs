using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Program
    {
        static void ManipulatingStrings()
        {
            string fname = "Medo";
            string lname="Ali";
            string fullname = fname.ToLower() +" " + lname;
            string fn = string.Format(fname, lname);

        }
        static void Main(string[] args)
        {
            string name = "Mohamaed Saed Ali";
            string substr = name.Substring(2, 4);
            Console.WriteLine(substr);
            string f = "medo";
            string l = "Medo";
            if (f == l)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            if (name.Contains("ae"))
            {
                Console.WriteLine("Well");
            }
            else
            {
                //string substr = name.Substring(2, 4);
                //Console.WriteLine(substr);
            }
            Console.WriteLine("hey BoB!");
            Console.WriteLine("Enter the wage");
            string wage = Console.ReadLine();
            int val;
            if (int.TryParse(wage, out val))
            {
                Console.WriteLine($"Success {val} ");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
