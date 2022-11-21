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
            List<String> names = new List<string>
            {
                "Mohammed",
                "Khalid",
                "Waleed",
                "Nasser",
                "Leen",
                "Sara",
                "Lujain",
                "Shahad"};
            foreach(String name in names)
            {
                Console.WriteLine("Give " + name + "a laptop");
                Console.WriteLine("Give " + name + "the projct designs");
            }
            Console.ReadKey();
        }
    }
}
