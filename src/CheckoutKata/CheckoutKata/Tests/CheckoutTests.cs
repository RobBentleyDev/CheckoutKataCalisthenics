using CheckoutKata.Main;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class CheckoutTests
    {
        [Test]
        public void testWhenIScanNothingThenTotalIsZero()
        {
            Money expectedTotal = new Money(0);
            Checkout checkout = new Checkout();
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemAThenTotalIsFifty()
        {
            Money expectedTotal = new Money(50);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("A"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemBThenTotalIsThirty()
        {
            Money expectedTotal = new Money(30);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("B"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [Test]
        public void testWhenIScanItemAAndBThenTotalIsEighty()
        {
            Money expectedTotal = new Money(80);
            Checkout checkout = new Checkout();
            checkout.Scan(new ItemCode("A"));
            checkout.Scan(new ItemCode("B"));
            Money actualTotal = checkout.Total();

            Assert.AreEqual(expectedTotal, actualTotal);
        }
    }
}