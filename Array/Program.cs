using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the size of the array
            const int size = 5;
            string[] names = new string[size];

            // Input names into the array
            Console.WriteLine("Enter 5 names:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            // Display all names
            Console.WriteLine("\nThe names you entered are:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            // Search for a specific name
            Console.Write("\nEnter a name to search: ");
            string searchName = Console.ReadLine();
            bool found = false;

            foreach (var name in names)
            {
                if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"{searchName} is in the list.");
            }
            else
            {
                Console.WriteLine($"{searchName} is not in the list.");
            }

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
