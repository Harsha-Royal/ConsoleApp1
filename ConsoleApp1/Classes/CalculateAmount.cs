using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Interfaces;

namespace VendingMachine.Classes
{
    public class CalculateAmount : ICalculateAmount
    {
        AcceptCoin _acceptCoin;
        ReadTheValueFromUser _readTheValueFromUser;
        public CalculateAmount( AcceptCoin acceptCoin,ReadTheValueFromUser readTheValueFromUser)
        {
            _acceptCoin = acceptCoin;
            _readTheValueFromUser = readTheValueFromUser;   
        }

       public double CurrentAmount=0;
       public double ReturnCoins=0;



        public void AcceptTheCoinsUntilThePriceReached(double ItemPrice)
        {
            


            while (ItemPrice > CurrentAmount)
            {
                Console.WriteLine("Selected Item Price in ${0} , Current Amount Recieved in ${1}",ItemPrice,CurrentAmount);

                try
                {
                    string InputCurrency = _readTheValueFromUser.Data();
                    double ReceivedAmount = _acceptCoin.EnterTheAmount(InputCurrency);

                    CurrentAmount += ReceivedAmount;

                    CurrentAmount = Math.Round(CurrentAmount, 2);
                }
                catch(Exception e)
                {
                    Console.WriteLine("enter valid coin");
                }

               
            }

            ReturnCoins = CurrentAmount - ItemPrice;
            ReturnCoins = Math.Round(ReturnCoins,2);

            Console.WriteLine("The Amount to be returned is {0}", ReturnCoins);


            Console.WriteLine("<------------------THANK YOU for the Purchase------------------->");


        }


    }
}
