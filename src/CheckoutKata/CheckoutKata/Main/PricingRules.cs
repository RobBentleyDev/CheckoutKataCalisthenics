using System.Collections.Generic;

namespace CheckoutKata.Main
{
    public class PricingRules
    {
        private Dictionary<ItemCode, Money> pricingRules;

        public PricingRules()
        {
            pricingRules = new Dictionary<ItemCode, Money>();
            pricingRules.Add(new ItemCode("A"), new Money(50));
            pricingRules.Add(new ItemCode("B"), new Money(30));
        }

        public Money get(ItemCode itemCode)
        {
            return pricingRules[itemCode];
        }

        public void ItemCodeScanned(ItemCode itemCode,
            Money totalMoney)
        {
            Money itemPrice = pricingRules[itemCode];
            totalMoney.Add(itemPrice);
        }
    }
}
