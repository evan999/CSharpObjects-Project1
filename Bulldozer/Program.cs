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
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien();

            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);
            worker.Count(4.5f);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }

    public class GeneralObject
    {
        public GeneralObject()
        {

        }

        public bool moves { get; set; }
        public string color { get; set; }
    }

    public class Human : GeneralObject
    {
        public Human()
        {

        }

        public string name { get; set; }
    }
        public class Man : Human

        {
            public Man()
            {

            }
        }

        public class Woman : Human
        {
            public Woman()
            {

            }
        }

    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }

        public void Count(int number)
        {
            if (Total == null)
            {
                Total = 0;
            }

            Total = Total + Convert.ToSingle(number);
            Console.WriteLine(Total.ToString());
        }

        public void Count(float number)
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }

        public void Count (int num1, float num2, double num3)
        {
            //code to add all three
            //add to Total
        }


        public float Total { get; set; }
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

    public class Kart : GeneralObject
    {
        public Kart ()
        {
            
        }
        
        
        public string manufacturer { get; set; }
        
    }

    public class Alien : GeneralObject
    {
        public Alien()
        {
        }
        public string planet { get; set; }
    }
}
