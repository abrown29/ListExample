using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            foreach(bool value in boolList)
                if(value == true)
                {
                    Console.WriteLine("Better bring an umbrella");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            Console.ReadKey();
        }
    }
}
