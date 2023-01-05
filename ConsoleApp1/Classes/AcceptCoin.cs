using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Interfaces;

namespace VendingMachine.Classes
{
    public class AcceptCoin : IAcceptCoin
    {

        public virtual double EnterTheAmount(string InputCurrency)
        {
            InputCurrency = InputCurrency.ToString().ToUpper().Trim();

            ICurrency? Currency = null;

            if(InputCurrency == "NICKEL")
            {
                Currency = new Nickel();
                return Currency.ConvertToDollar();
            }
            else if(InputCurrency == "DOLLAR")
            {
                Currency = new Dollar();
                return Currency.ConvertToDollar();
            }
            else if (InputCurrency == "QUARTER")
            {
                Currency = new Quarter();
                return Currency.ConvertToDollar();
            }
            else if (InputCurrency == "DIME")
            {
                Currency = new Dime();
                return Currency.ConvertToDollar();
            }
            else if (InputCurrency == "PENNY")
            {
                Console.WriteLine("Penny is Not accepted");
                return 0;
               
            }
            else
            {
                Console.WriteLine("Enter the valid Coin");
            }

            return 0;




        }







    }
}
