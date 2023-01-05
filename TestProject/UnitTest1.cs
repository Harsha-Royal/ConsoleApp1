using Moq;
using VendingMachine.Classes;
using VendingMachine.Interfaces;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {

        AcceptCoin acceptCoin = new AcceptCoin();

        [TestMethod]
        [DataRow("  Nickel   ",0.05)]
        [DataRow("Dime   ",0.1)]
        [DataRow("   Quarter",0.25)]
        [DataRow("DOLLAR",1)]
        public void TestMethodForAcceptCoin(string currency,double value)
        { 
           double currentValue =  acceptCoin.EnterTheAmount(currency);


            Assert.AreEqual(value, currentValue);
        }

        [TestMethod]
        [DataRow("  Nickel   ")]
        [DataRow("Dime   ")]
        [DataRow("   Quarter")]
        [DataRow("DOLLAR")]
        public void TestMethodForSuccessfulPurchase(string currency)
        {
            

            Mock<ReadTheValueFromUser> readtheValueFromUserMock = new Mock<ReadTheValueFromUser>();
            readtheValueFromUserMock.Setup(x => x.Data()).Returns(currency);


            CalculateAmount calculateAmount = new CalculateAmount(acceptCoin, readtheValueFromUserMock.Object);
         
            calculateAmount.AcceptTheCoinsUntilThePriceReached(1);

            Assert.AreEqual(0, calculateAmount.ReturnCoins);
        }


        [TestMethod]
        [DataRow("  Nickel   ",0.65, 0)]
        [DataRow("Dime   ", 0.65,  0.05)]
        [DataRow("   Quarter", 0.65, 0.10)]
        [DataRow("DOLLAR", 0.65, 0.35)]
        public void TestMethodForSuccessfulPurchaseWithReturnCoins(string currency,double item,double returncoins)
        {


            Mock<ReadTheValueFromUser> readtheValueFromUserMock = new Mock<ReadTheValueFromUser>();
            readtheValueFromUserMock.Setup(x => x.Data()).Returns(currency);


            CalculateAmount calculateAmount = new CalculateAmount(acceptCoin, readtheValueFromUserMock.Object);

            calculateAmount.AcceptTheCoinsUntilThePriceReached(item);

            Assert.AreEqual(returncoins, calculateAmount.ReturnCoins);
        }



    }
}