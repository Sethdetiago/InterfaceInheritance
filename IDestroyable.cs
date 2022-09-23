using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritance
{
    internal interface IDestroyable
    {
        //property to store audio file to be played upon destruction
        string DestroySound { get; set; }

        //method to destroy

        void Destroy();

    }
}
