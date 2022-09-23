using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    internal class Car : Vehicle, IDestroyable 
    {
        
       

        public string DestroySound { get; set; }
        //Creating a list of nearby destroyable objects
        public List<IDestroyable> DestroyablesNearby;
        
        //simple constuctor
        public Car(float speed, string color) : base(speed, color)
        {
            //initialize interfaces property with a value in the constructor
            DestroySound = "explosionsound.mp3";
            //initialize list of destroyable
            DestroyablesNearby = new List<IDestroyable>();

        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestroySound);
            Console.WriteLine("Create fire");
            
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }



    }
}
