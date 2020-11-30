using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine($"Dialog #{i}");

                Console.WriteLine($"Kanye: \"{Quoter.Kanye()}\"");

                Console.WriteLine($"Ron: {Quoter.Ron()}");

                Console.WriteLine();

            }
        }

    }
}
