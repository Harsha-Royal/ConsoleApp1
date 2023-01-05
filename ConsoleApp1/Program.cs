using System;
using VendingMachine.Classes;
using VendingMachine.Interfaces;

namespace VendingMachine
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            //Products Information
            Dictionary<string, double> ProductWithTheirPrices = new Dictionary<string, double>();
            ProductWithTheirPrices.Add("Cola", 1.00);
            ProductWithTheirPrices.Add("Chips", 0.50);
            ProductWithTheirPrices.Add("Candy", 0.65);

            //Display Products
            IDisplayProducts displayProducts = new DisplayProducts();
            displayProducts.Display(ProductWithTheirPrices);



            //Get the Order Details
            int OrderSelected = 0;
            try
            {
                OrderSelected = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(OrderSelected);
            }
            catch(Exception e)
            {
                Console.WriteLine("Enter a Valid Order");
            }
            Console.WriteLine("Please Dispense the coins in Dollar , Nickel , Quater, Dime");



            AcceptCoin acceptcoin = new AcceptCoin();
            ReadTheValueFromUser readTheValueFromUser = new ReadTheValueFromUser();
            CalculateAmount calculateAmount = new CalculateAmount(acceptcoin, readTheValueFromUser);

            calculateAmount.AcceptTheCoinsUntilThePriceReached(ProductWithTheirPrices.ElementAt(OrderSelected - 1).Value);

            Console.ReadLine();
        }

      
    }
}