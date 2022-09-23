using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    internal class Chair: Furniture, IDestroyable
    {
        //implementing inerface members
        public string DestroySound { get; set; }

        //Simple Constuctor
        public Chair(string color, string material) : base(color, material)
        {
            DestroySound = "chairdestructionsound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} chair was destroyed");
            Console.WriteLine($"Playing {DestroySound}");
            Console.WriteLine("Spawning chair parts");
        }

        
    }
}
