using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating a couple of chair objects
            Chair foldingChair = new Chair("Gold", "Metal");
            Chair rockingChair = new Chair("Brown", "Wood");
            
            //creating car object
            Car bomberCar = new Car(100f, "Black");

            //Placing Chairs near the car
            bomberCar.DestroyablesNearby.Add(rockingChair);
            bomberCar.DestroyablesNearby.Add(foldingChair);

            //Blowing up the car
            bomberCar.Destroy();

            Console.ReadKey();
        }
    }
}
