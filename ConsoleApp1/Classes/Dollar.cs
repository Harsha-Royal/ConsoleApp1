using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Interfaces;

namespace VendingMachine.Classes
{
    internal class Dollar : ICurrency
    {
        public double ConvertToDollar()
        {
            return 1;
        }

    }
}
