using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a name to give him/her what he/she needs");
            Console.WriteLine("Type exit at anytime to close the app");

            String input = Console.ReadLine();
            Dictionary<String, bool> dictionary = new Dictionary<string, bool>();
            dictionary.Add(input, true);
            Console.WriteLine("Give " + input + " a laptop");
            Console.WriteLine("Give " + input + " the project design");

            Console.ReadKey();
        }
    }
}
