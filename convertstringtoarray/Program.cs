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
            string str = "I love arrays they are my favorite";

            string[] container = (from c in str.Split()
                                 select c).ToArray();

            foreach (var item in container)
                Console.WriteLine(item);

            Console.ReadKey();

        }
    }
}
