using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Interface_s_
{
    // Technique #1:
    // Door has a parent class (inherits from) and also an interface
    
    internal class Door : Bottle, IOpen
    {
        // This child class has 0 or 1 inheritting parent class and then followed by any number of Interfaces
        

        // another Method Signature Instance with different parameters
        //the computer will run if it has the requested parameters.
        public void Open(string doorName)
        {
            //Console.WriteLine($"Door opens to {IOpen._maxRotation} degrees");
        }
    
    }
    

    /*
    internal class Door : IOpen, 
    */
}
