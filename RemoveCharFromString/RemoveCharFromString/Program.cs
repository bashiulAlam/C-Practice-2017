using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCharFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            char c = Convert.ToChar(Console.ReadLine());

            int index = str.IndexOf(c);
            String newStr = str.Remove(index, 1);

            Console.WriteLine("New str : " + newStr);
            Console.ReadKey();
        }
    }
}
