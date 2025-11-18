using Decorator_CL.Contracts;

namespace Decorator_CL.Decorators
{
    public class Sugar: Ingredient
    {
        private int amount;

        public Sugar(int amount)
        {
            this.amount = amount;
        }
        public override double GetTemperature()
        {
            return drink.GetTemperature();
        }

        public override double GetPrice()
        {
            return drink.GetPrice() + (amount*5);
        }
        
        public override string GetInfo()
        {
            return drink.GetInfo();
        }
    }
}