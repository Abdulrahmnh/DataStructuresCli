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
            Dictionary<String, bool> dictionary = new Dictionary<string, bool>();
            Console.WriteLine("Type a name to give him/her what he/she needs");
            Console.WriteLine("Type exit at anytime to close the app");

            String input = Console.ReadLine();

            while (input != "exit")
            {
                if (!dictionary.ContainsKey(input))
                {
                    dictionary.Add(input, true);
                    Console.WriteLine("Give " + input + " a laptop");
                    Console.WriteLine("Give " + input + " the project design");

                    Console.WriteLine("Type a name to give him/her what he/she needs");
                    Console.WriteLine("Type exit at anytime to close the app");
                }
                else
                {
                    Console.WriteLine(input + " is already added!");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Here what you added!");
            foreach (KeyValuePair<String, bool> item in dictionary)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
