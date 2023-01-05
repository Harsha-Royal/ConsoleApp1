using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Interfaces;

namespace VendingMachine.Classes
{
    public class DisplayProducts : IDisplayProducts
    {
 
           static int tableWidth = 73;

        public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        public void Display(Dictionary<string, double> ProductsWithTheirPrices)
        {
            Console.Clear();
            Console.WriteLine("<----------------------------Vending Machine---------------------------->");

            PrintLine();
            PrintRow("ID", "ITEM", "PRICE IN $");
            PrintLine();
            int i = 1;
            foreach (var products in ProductsWithTheirPrices)
            {
                PrintRow(i.ToString(), products.Key, products.Value.ToString());
                i++;
            }
            PrintLine();
            Console.WriteLine("<----------------------------Please select the order by entering the respective ID--------------------------->");


        }


    }
}
