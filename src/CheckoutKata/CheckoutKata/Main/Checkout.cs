namespace CheckoutKata.Main
{
    public class Checkout
    {
        private Money totalMoney = new Money(0);

        private PricingRules pricingRules = new PricingRules();

        public Money Total()
        {
            return totalMoney;
        }

        public void Scan(ItemCode itemCode)
        {
            pricingRules.ItemCodeScanned(itemCode, totalMoney);
        }
    }
}
