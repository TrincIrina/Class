using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dishwasher dishwasher = new Dishwasher("Sumsung", 60, 60, 40, 84);
            dishwasher.Print();
            Console.WriteLine();

            Dishwasher[] dishwashers = new Dishwasher[5];
            dishwashers[0] = dishwasher;
            dishwashers[1] = new Dishwasher("Bork", 40, 56);
            dishwashers[2] = new Dishwasher("Hansa", 60, 50, 64);
            dishwashers[3] = new Dishwasher("Bosh", 84.5, 45, 60, 97);
            dishwashers[4] = new Dishwasher("Midea", 44, 42, 53.5);
            int prog = 2, sets = 3;
            Dishwasher.ChangeCharacteristics(ref prog, ref sets);
            for (int i = 0; i < dishwashers.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {dishwashers[i].ToString()};");
            }
        }
    }
}
