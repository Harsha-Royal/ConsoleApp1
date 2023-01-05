using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Interfaces;

namespace VendingMachine.Classes
{
    internal class Quarter : ICurrency
    {
        public double ConvertToDollar()
        {
            return 0.25;
        }
    }
}
