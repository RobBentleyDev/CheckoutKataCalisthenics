using CheckoutKata.Main;
using NUnit.Framework;

namespace CheckoutKata.Tests
{
    public class MoneyTests
    {
        [Test]
        public void testMoney1IsNotEqualToMoney2()
        {
            Money money1 = new Money(1);
            Money money2 = new Money(2);

            Assert.AreNotEqual(money1, money2);
        }
        
        [Test]
        public void testMoney1IsEqualToMoney1()
        {
            Money money1 = new Money(1);
            Money money12 = new Money(1);

            Assert.AreEqual(money1, money12);
        }
    }
}
