using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulldozer
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dozer = new BullDozer("Yellow", "Mini");
            dozer.color = "Yellow";
            dozer.size = "Mini";

            var dozer2 = new BullDozer("Red", "Large");

            Console.WriteLine("Bulldozer 1 is " + dozer.color);
            Console.WriteLine("Bulldozer 2 is " + dozer.color);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }

    public class BullDozer
    {
        public BullDozer (string _color, string _size)
        {
            this.color = _color;
            this.size = _size;
        }

        public string color { get; set; }
        public string size { get; set; }
    }
}
