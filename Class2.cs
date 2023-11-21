using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    partial class Dishwasher
    {
        public partial void Print()
        {
            Console.WriteLine($"Name dishwasher - {name}");
            Console.WriteLine($"Characteristics: Height: {height} sm;");
            Console.WriteLine($"\t\t Widht: {width} sm;");
            Console.WriteLine($"\t\t Depth: {depth} sm;");
            Console.WriteLine($"\t\t Weight: {weight} kg;");
            Console.WriteLine($"\t\t Number programs: {numberPrograms};");
            Console.WriteLine($"\t\t Sets dishes: {setsDishes}");
        }
    }
}
