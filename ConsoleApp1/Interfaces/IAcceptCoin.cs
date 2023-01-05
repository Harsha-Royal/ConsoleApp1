using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Interfaces
{
    public interface IAcceptCoin
    {
        public double EnterTheAmount(string InputCurrency);
    }
}
