using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Interfaces
{
    internal interface IDisplayProducts
    {
        void PrintLine();

        void PrintRow(params string[] columns);

        string AlignCentre(string text, int width);

        void Display(Dictionary<string,double> ProductsWithTheirPrices);

    }
}
