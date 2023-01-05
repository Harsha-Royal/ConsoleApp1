using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Classes;

namespace VendingMachine.Interfaces
{
    internal interface ICalculateAmount
    {
        void AcceptTheCoinsUntilThePriceReached(double ItemPrice);
    }
}
