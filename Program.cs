using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Find the index of the word 'the'!";
            Console.WriteLine(str);
            Console.WriteLine("Input substring: ");
            string sub = Console.ReadLine();
            Console.WriteLine("Sentence contains substring = " + str.Contains(sub));
            int index = str.IndexOf(sub);
            Console.WriteLine("Index of first substring presence: " + index);

            Console.ReadKey();
        }
    }
}
