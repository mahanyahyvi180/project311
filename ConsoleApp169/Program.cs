using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp169
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder1 = new StringBuilder("Happy Birthday Jane");
            var builder2 = new StringBuilder("good bye greg");

            Console.WriteLine($"Before replacements:\n{builder1}\n{builder2}");

            builder1.Replace("Jane", "Greg");
            builder2.Replace('g', 'G', 0, 5);

            Console.WriteLine($"\nAfter replacements:\n{builder1}\n{builder2}");

            Console.ReadLine();
        }
    }
}
