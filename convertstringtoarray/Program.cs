using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertstringtoarray
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Convert this string to an array of string";

            string[] container = (from words in str.Split()
                                 select words).ToArray();

            foreach (var item in container)
                Console.WriteLine(item);

            Console.ReadKey();

        }
    }
}
