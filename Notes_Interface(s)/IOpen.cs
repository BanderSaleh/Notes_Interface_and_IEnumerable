using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Interface_s_
{
    // Added New Interface (instead of class)
    internal interface IOpen
    {
        // We can have:
        // Fields
        const double _maxRotationalValue = 90;
        double _minValue = 0;

        // Method Signature
        public void Open();
        public void Close();
        public void SlamShut();
    }
}
